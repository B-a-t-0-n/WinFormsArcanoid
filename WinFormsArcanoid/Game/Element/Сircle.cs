using System.Drawing.Drawing2D;
using WinFormsArcanoid.Game.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsArcanoid.Game.Element
{
    public class Circle : PictureBox, ICircle
    {
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
    }
}
