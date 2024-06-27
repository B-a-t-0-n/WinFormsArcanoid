using System.Drawing.Drawing2D;
using WinFormsArcanoid.Game.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsArcanoid.Game.Element
{
    public class Circle : PictureBox, ICircle
    {
        public bool IsLeft { get; set; } = false;
        public bool IsRight { get; set; } = false;
        public bool IsUp { get; set; } = false;
        public bool IsDown { get; set; } = false;

        public int Speed { get; set; }
        public int Radius { get; set; }
        public Color Background {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }
        public int Damage { get; set; }
        Point ICircle.Location 
        {
            get
            {
                return this.Location;
            }
            set
            {
                this.Location = value;
            }
        }

        private Platform? _platform;

        public Circle(int radius, Color background, int damage, Point location, int speed)
        {
            Radius = radius;
            Background = background;
            Damage = damage;
            Location = location;
            Speed = speed;

            this.Size = new Size(Radius / 2, Radius / 2);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

        public void AddElementGame(Platform platform)
        {
            _platform = platform;
        }

        public void Movement()
        {
            if (IsLeft)
            {
                if(CheckMovement(0 - Speed, 0))
                    Location = new Point(Location.X - Speed, Location.Y);
                else
                {
                    IsLeft = false;
                    IsRight = true;
                }
            }

            if (IsRight)
            {
                if (CheckMovement(Speed, 0))
                    Location = new Point(Location.X + Speed, Location.Y);
                else
                {
                    IsLeft = true;
                    IsRight = false;

                }
            }

            if (IsUp)
            {
                if (CheckMovement(0, 0 - Speed))
                    Location = new Point(Location.X, Location.Y - Speed);
                else
                {
                    IsUp = false;
                    IsDown = true;
                }
            }

            if (IsDown)
            {
                if (CheckMovement(0, Speed) && CheckPlatform())
                    Location = new Point(Location.X, Location.Y + Speed);
                else
                {
                    IsUp = true;
                    IsDown = false;
                }
            }


        }

        private bool CheckMovement(int x , int y)
        {
            var container = this.Parent;
            
            if (Location.Y + y > container!.Height - Height ||
               Location.Y + y < 0 ||
               Location.X + x > container!.Width - Width ||
               Location.X + x < 0)
            {
                return false;
            }

            return true;
        }

        private bool CheckPlatform()
        {
            if (_platform != null && Bounds.IntersectsWith(_platform.Bounds))
            {
                return false;
            }
            return true;
        }
    }
}
