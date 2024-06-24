using WinFormsArcanoid.Game.Interfaces;

namespace WinFormsArcanoid.Game.Element
{
    public class Сircle : IСircle
    {
        public int Radius { get; set; }
        public Color Background { get; set; }
        public int Damage { get; set; }
        public Point Location { get; set; }
    }
}
