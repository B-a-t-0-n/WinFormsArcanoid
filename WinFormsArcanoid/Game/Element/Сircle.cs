using System.Drawing.Drawing2D;
using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game.Element
{
    public class Circle : PictureBox, IСircle
    {
        public int Radius { get; set; }
        public Color Background { get; set; }
        public int Damage { get; set; }
        Point IСircle.Location 
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

        public Circle(int radius, Color background, int damage, Point location)
        {
            Radius = radius;
            Background = background;
            Damage = damage;
            Location = location;

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
    }
}
