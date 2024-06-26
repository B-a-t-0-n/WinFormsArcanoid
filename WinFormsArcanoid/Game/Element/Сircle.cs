using System.Drawing.Drawing2D;
using WinFormsArcanoid.Game.Interfaces;

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

        public Circle(int radius, Color background, int damage, Point location, int speed)
        {
            Radius = radius;
            Background = background;
            Damage = damage;
            Location = location;
            Speed = speed;

            this.Size = new Size(Radius / 2, radius / 2);
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

        public void Movement()
        {
            var container = this.Parent;

            if (IsLeft && CheckMovement(0 - Speed, 0))
            {
                Location = new Point(Location.X - Speed, 0);
            }

            if (IsRight && CheckMovement(Speed, 0))
            {
                Location = new Point(Location.X + Speed, 0);
            }

            if (IsUp && CheckMovement(0, 0 - Speed))
            {
                Location = new Point(0, Location.Y - Speed);
            }

            if (IsDown && CheckMovement(0, Speed))
            {
                Location = new Point(0, Location.Y + Speed);
            }
        }

        private bool CheckMovement(int x , int y)
        {
            return true;
        }
    }
}
