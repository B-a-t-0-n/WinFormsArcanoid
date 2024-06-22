namespace WinFormsArcanoid.Game.Interfaces
{
    public interface IBlock
    {
        Color Backgroub { get; set; }
        int Endurance { get; set; }
        Point Location { get; set; }
        Size Size { get; set; }

        void Destruction();
    }
}