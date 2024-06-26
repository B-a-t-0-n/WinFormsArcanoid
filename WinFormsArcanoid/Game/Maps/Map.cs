using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game.Maps
{
    public class Map
    {
        public IBlock?[,] Blocks { get; set; }

        public static Color[] Colors { get; set; } = [Color.FromArgb(24, 158, 252)];

        public Map(string typeMap = MapDefaults.RANDOM)
        {
            bool hasFillMap = true;

            switch (typeMap)
            {
                case MapDefaults.RANDOM:
                    hasFillMap = false;
                    break;

                case MapDefaults.FILL:
                    hasFillMap = true;
                    break;
            }

            Blocks = GenerateMap(5, 5, [new Block(Colors[0], 1, new Point(0, 0), new Size(95, 33))], hasFillMap);
        }

        public Map(IBlock?[,] Blocks)
        {
            this.Blocks = Blocks;
        }

        public static IBlock?[,] GenerateMap(int x, int y, IBlock[] blocks, bool hasFillMap = true, bool hasRandomColors = false)
        {
            var map = new IBlock?[y, x]; 
            Random rnd = new Random();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(rnd.Next(0,3) == 2 && !hasFillMap)
                    {
                        map[i, j] = null;
                        continue;
                    }

                    var index = rnd.Next(0, blocks.Length);
                    map[i ,j] = blocks[index].Copy();
                    map[i, j]!.Location = new Point((map[i,j]!.Size.Width + 5) * j + 10, (map[i, j]!.Size.Height + 5) * i + 15);

                    if (hasRandomColors)
                    {
                        map[i,j]!.Background = Map.Colors[rnd.Next(0,Map.Colors.Length)];
                    }
                }
            }

            return map;
        }

    }
}
