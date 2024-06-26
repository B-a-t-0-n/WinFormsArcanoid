using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsArcanoid.Game.Element
{
    public class Platform: Panel
    {
        public int Speed { get; set; }

        public bool isLeft { get; set; } = false;
        public bool isRight { get; set; } = false;

        public Platform(Color backgroub, Point location, Size size, int speed)
        {
            BackColor = backgroub;
            Location = location;
            Size = size;
            Speed = speed;
        }

        public void Movement(int x, int y) 
        {
            var container = this.Parent;

            if(Location.Y + y < container!.Height && Location.Y + y > 0 && Location.X + x < container!.Width - Width && Location.X + x > 0)
            {
                Location = new Point(Location.X + x, Location.Y + y);
            }
        }
    }
}
