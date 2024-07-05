using WinFormsArcanoid.Game.Element;

namespace WinFormsArcanoid.Game.Movements
{
    public static class MovementPlatform
    {
        public static bool IsLeft { get; set; } = false;
        public static bool IsRight { get; set; } = false;

        public static void Movement(Platform platform)
        {
            if (IsLeft) 
            {
                if (CheckMovement(platform, "left"))
                    platform.Location = new Point(platform.Location.X - platform.Speed, platform.Location.Y);
            }
            if (IsRight)
            {
                if (CheckMovement(platform, "right"))
                    platform.Location = new Point(platform.Location.X + platform.Speed, platform.Location.Y);
            }
  
        }

        private static bool CheckMovement(Platform platform, string movement)
        {
            movement.ToLower();
            var container = platform.Parent;

            switch (movement)
            {
                case "left":
                    if(platform.Location.X - platform.Speed > 0)
                        return true;
                    return false;

                case "right":
                    if (platform.Location.X + platform.Speed < container!.Width - platform.Width)
                        return true;
                    return false;
                default:
                    throw new NotImplementedException("неивестное направление");
            }

            
        }
    }
}
