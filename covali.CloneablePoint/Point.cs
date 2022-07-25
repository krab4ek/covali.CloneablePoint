namespace covali.CloneablePoint
{
    internal class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point()
        {

        }
        public override string ToString() => $"X={X}; Y={Y}";

        public object Clone()
        {
            return new Point(this.X, this.Y);
        }
    }
}
