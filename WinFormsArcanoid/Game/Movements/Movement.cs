using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Maps;

namespace WinFormsArcanoid.Game.Movements
{
    public class Movement
    {
        public Platform Platform { get; set; }
        public Map Map { get; set; }
        public Circle Circle { get; set; }

        public Movement(Platform platform, Map map, Circle circle)
        {
            Platform = platform;
            Map = map;
            Circle = circle;
        }


    }
}
