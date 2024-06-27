using System.Collections.Generic;
using WinFormsArcanoid.Game.Element;
using WinFormsArcanoid.Game.Maps;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsArcanoid.Game
{
    public class Arcanoid
    {
        public Map Map { get; set; }
        public Platform Platform { get; set; }
        public Circle Circle { get; set; }

        private Control _container;
        private PictureBox? _pictureBox;
        private Timer _timerMovement;

        public Arcanoid(Control container, string randomMap)
        {
            _container = container;
            this.Map = new Map(randomMap);
            Platform = new(Color.FromArgb(24, 158, 252), new Point(183, 869), new Size(123, 16), 6);

            foreach (var item in _container.Controls)
            {
                if (item is PictureBox)
                {
                    _pictureBox = (PictureBox)item;
                }
            }

            Circle = new Circle(50, Color.FromArgb(145, 195, 231), 1, new Point(234, 844), 3);
            Circle.Image = Properties.Resources.GmOC;
            Circle.SizeMode = PictureBoxSizeMode.Zoom;
            Circle.AddElementGame(Platform);

            _timerMovement = new Timer();
            _timerMovement.Enabled = false;
            _timerMovement.Interval = 10;
            _timerMovement.Tick += timerMovement_Tick!;
        }

        public void Start()
        {
            LoadGame();
            _timerMovement.Enabled = true;
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

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            if (Platform.IsLeft)
                Platform.Movement(0 - Platform.Speed, 0);
            if (Platform.IsRight)
                Platform.Movement(Platform.Speed, 0);

            if(!Circle.IsUp && !Circle.IsDown && !Circle.IsLeft && !Circle.IsRight && Platform.IsLeft)
            {
                Circle.IsLeft = true;
                Circle.IsUp = true;
            }

            if (!Circle.IsUp && !Circle.IsDown && !Circle.IsLeft && !Circle.IsRight && Platform.IsRight)
            {
                Circle.IsRight = true;
                Circle.IsUp = true;
            }

            Circle.Movement();
        }
    }
}
