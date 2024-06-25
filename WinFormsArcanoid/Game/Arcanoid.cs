using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Interfaces;
using WinFormsArcanoid.Game.Maps;

namespace WinFormsArcanoid.Game
{
    public class Arcanoid
    {
        public Map Map { get; set; }

        private Control _container;
        private PictureBox? _pictureBox;

        public Arcanoid(Control container, string randomMap)
        {
            _container = container;
            this.Map = new Map(randomMap);

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
            Platform platform = new(Color.FromArgb(24, 158, 252), new Point(183, 869), new Size(123, 16), 10); 

            

        }

        private void LoadGame(Platform platform, IEnumerable<IBlock> blocks, Circle circle)
        {
            if (_pictureBox != null)
                _pictureBox.Hide();

            _container.Controls.Add(platform);
            _container.Controls.Add(circle);


        }

       

    }
}
