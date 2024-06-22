namespace WinFormsArcanoid.Game.Interfaces
{
    public interface IСircle
    {
        Color Background { get; set; }
        int Damage { get; set; }
        Point Location { get; set; }
        int Radius { get; set; }
    }
}