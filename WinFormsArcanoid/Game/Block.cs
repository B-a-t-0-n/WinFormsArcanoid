
using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game
{
    public class Block : IBlock
    {
        public Color Backgroub { get; set ; }
        public int Endurance {
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
        public Point Location { get; set; }
        public Size Size { get; set ; }
        private int _endurance;

        public void Destruction()
        {
            throw new NotImplementedException();
        }

    }
}
