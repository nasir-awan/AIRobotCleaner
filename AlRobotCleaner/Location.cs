namespace AIRobotCleaner.Domain
{
    public class Location : ILocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(ILocation other)
        {
            return X == other.X ? Y.CompareTo(other.Y) : X.CompareTo(other.X);
        }
    }
}
