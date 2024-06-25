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
            switch (typeMap)
            {
                case MapDefaults.RANDOM:
                    Blocks = GenerateRandomMap(10, 5, [new Block(Colors[0], 10, new Point(0,0), new Size(10,10))]);
                    break;

                case MapDefaults.FILL:
                    Blocks = GenerateFillMap(10, 5, [new Block(Colors[0], 10, new Point(0, 0), new Size(10, 10))]);
                    break;

                default:
                    Blocks = new IBlock[0,0];
                    break;
            }
            
        }

        public Map(IBlock?[,] Blocks)
        {
            this.Blocks = Blocks;
        }

        public static IBlock?[,] GenerateRandomMap(int x, int y, IBlock[] blocks, bool hasRandomColors = false)
        {
            var map = new IBlock?[y, x]; 
            Random rnd = new Random();

            for (int i = 0; i < blocks.GetLength(0); i++)
            {
                for (int j = 0; j < blocks.GetLength(1); j++)
                {
                    if(rnd.Next(0,3) == 2)
                    {
                        map[i, j] = null;
                        continue;
                    }

                    var index = rnd.Next(0, blocks.Length);
                    map[i,j] = blocks[index].Copy();
                    map[i,j]!.Location = new Point(map[i,j]!.Size.Width * j, map[i, j]!.Size.Height * i);

                    if (hasRandomColors)
                    {
                        map[i,j]!.Background = Map.Colors[rnd.Next(0,Map.Colors.Length)];
                    }
                }
            }

            return map;
        }

        public static IBlock?[,] GenerateFillMap(int x, int y, IBlock[] blocks, bool hasRandomColors = false)
        {
            var map = new IBlock?[y, x];
            Random rnd = new Random();

            for (int i = 0; i < blocks.GetLength(0); i++)
            {
                for (int j = 0; j < blocks.GetLength(1); j++)
                {
                    var index = rnd.Next(0, blocks.Length);
                    map[i, j] = blocks[index].Copy();
                    map[i, j]!.Location = new Point(map[i, j]!.Size.Width * j, map[i, j]!.Size.Height * i);

                    if (hasRandomColors)
                    {
                        map[i, j]!.Background = Map.Colors[rnd.Next(0, Map.Colors.Length)];
                    }
                }
            }

            return map;
        }
    }


}
