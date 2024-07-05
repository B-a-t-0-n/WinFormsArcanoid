using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game.Element
{
    public class Block : Panel, IBlock
    {
        public Color Background
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
            }
        }
        public int Endurance
        {
            get
            {
                return _endurance;
            }
            set
            {
                _endurance = value;
                if (_endurance <= 0)
                {
                    Destruction();
                }
            }
        }
        Point IBlock.Location
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
        Size IBlock.Size {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
            }
        }

        private int _endurance;

        public Block(Color Background, int endurance, Point location, Size size)
        {
            this.Background = Background;
            ((IBlock)this).Location = location;
            Size = size;
            Endurance = endurance;
        }

        public void Destruction()
        {
            this.Hide();
        }

        public IBlock Copy() => new Block(BackColor, Endurance, Location, Size); 
    }
}
