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

        public Platform(Color backgroub, Point location, Size size, int speed)
        {
            BackColor = backgroub;
            Location = location;
            Size = size;
            Speed = speed;
        }

    }
}
