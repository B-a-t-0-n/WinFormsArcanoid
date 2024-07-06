using System.Runtime.InteropServices;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Interfaces;
using WinFormsArcanoid.Game.Maps;

namespace WinFormsArcanoid.Game.Movements
{
    public static class MovementCircle
    {
        public static bool IsLeft { get; set; } = false;
        public static bool IsRight { get; set; } = false;
        public static bool IsUp { get; set; } = false;
        public static bool IsDown { get; set; } = false;

        public static void Movement(Circle circle, Platform platform, Map map)
        {
            if (IsLeft)
            {
                if (CheckMovementInContainer(circle, 0 - circle.Speed, 0))
                    circle.Location = new Point(circle.Location.X - circle.Speed, circle.Location.Y);
                else if (CheckBlock(map, circle))
                {
                    foreach (var item in map.Blocks)
                    {
                        if (item is Block)
                        {
                            var block = (Block)item;

                            if (circle.Bounds.IntersectsWith(block.Bounds))
                            {
                                block.Endurance -= circle.Damage;
                            }
                        }
                    }
                    IsLeft = false;
                    IsRight = true;
                }
                else
                {
                    IsLeft = false;
                    IsRight = true;
                }
            }

            if (IsRight)
            {
                if (CheckMovementInContainer(circle, circle.Speed, 0))
                    circle.Location = new Point(circle.Location.X + circle.Speed, circle.Location.Y);
                else if (CheckBlock(map, circle))
                {
                    foreach (var item in map.Blocks)
                    {
                        if (item is Block)
                        {
                            var block = (Block)item;

                            if (circle.Bounds.IntersectsWith(block.Bounds))
                            {
                                block.Endurance -= circle.Damage;
                            }
                        }
                    }
                    IsLeft = true;
                    IsRight = false;
                }
                else
                {
                    IsLeft = true;
                    IsRight = false;

                }
            }

            if (IsUp)
            {
                if (CheckMovementInContainer(circle, 0, 0 - circle.Speed))
                    circle.Location = new Point(circle.Location.X, circle.Location.Y - circle.Speed);
                else if (CheckBlock(map, circle))
                {
                    foreach (var item in map.Blocks)
                    {
                        if (item is Block)
                        {
                            var block = (Block)item;

                            if (circle.Bounds.IntersectsWith(block.Bounds))
                            {
                                block.Endurance -= circle.Damage;
                            }
                        }
                    }
                    IsUp = false;
                    IsDown = true;
                }
                else
                {
                    IsUp = false;
                    IsDown = true;
                }
            }

            if (IsDown)
            {
                if (CheckMovementInContainer(circle, 0, circle.Speed) && CheckPlatform(platform, circle))
                    circle.Location = new Point(circle.Location.X, circle.Location.Y + circle.Speed);
                else if (CheckBlock(map, circle))
                {
                    foreach (var item in map.Blocks)
                    {
                        if (item is Block)
                        {
                            var block = (Block)item;

                            if (circle.Bounds.IntersectsWith(block.Bounds))
                            {
                                block.Endurance -= circle.Damage;
                            }
                        }
                    }
                    IsUp = true;
                    IsDown = false;
                }
                else
                {

                    IsUp = true;
                    IsDown = false;
                }
            }

        }

        private static bool CheckMovementInContainer(Circle circle, int x, int y)
        {
            var container = circle.Parent;

            if (circle.Location.Y + y < 0 ||
                circle.Location.X + x > container!.Width - circle.Width ||
                circle.Location.X + x < 0)
            {
                return false;
            }

            return true;
        }

        private static bool CheckPlatform(Platform platform, Circle circle)
        {
            if (circle.Bounds.IntersectsWith(platform.Bounds))
            {
                return false;
            }
            return true;
        }

        private static bool CheckBlock(Map map, Circle circle)
        {
            foreach (var item in map.Blocks)
            {
                if (item is Block)
                {
                    var block = (Block)item;

                    if (circle.Bounds.IntersectsWith(block.Bounds))
                    {
                        return false;
                    }
                }
            }
            return true;
        } 
    }
}
