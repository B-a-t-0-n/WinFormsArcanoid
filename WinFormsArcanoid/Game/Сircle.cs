using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game
{
    public class Сircle : IСircle
    {
        public int Radius { get; set; }
        public Color Background { get; set; }
        public int Damage { get; set; }
        public Point Location { get; set; }
    }
}
