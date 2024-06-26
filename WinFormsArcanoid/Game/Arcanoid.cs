using System.Windows.Forms;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Interfaces;
using WinFormsArcanoid.Game.Maps;

namespace WinFormsArcanoid.Game
{
    public class Arcanoid
    {
        public Map Map { get; set; }
        public Platform Platform { get; set; }
        public Circle Circle { get; set; }

        private Control _container;
        private PictureBox? _pictureBox;

        public Arcanoid(Control container, string randomMap)
        {
            _container = container;
            this.Map = new Map(randomMap);
            Platform = new(Color.FromArgb(24, 158, 252), new Point(183, 869), new Size(123, 16), 10);

            Circle = new Circle(50, Color.FromArgb(145, 195, 231), 1, new Point(234, 844));
            Circle.Image = Properties.Resources.GmOC;
            Circle.SizeMode = PictureBoxSizeMode.Zoom;

            foreach (var item in _container.Controls)
            {
                if (item is PictureBox)
                {
                    _pictureBox = (PictureBox)item;
                }
            }
        }
        
        public void Start()
        {
            LoadGame();
        }

        private void LoadGame()
        {
            if (_pictureBox != null)
                _container.Controls.Remove(_pictureBox);

            _container.Controls.Add(Platform);
            _container.Controls.Add(Circle);

            for (int i = 0; i < Map.Blocks.GetLength(0); i++)
            {
                for (int j = 0; j < Map.Blocks.GetLength(1); j++)
                {
                    _container.Controls.Add((Control?)Map.Blocks[i, j]);
                }
            }

            if (_pictureBox != null)
                _container.Controls.Add(_pictureBox);
        }

    }
}
