namespace covali.CloneablePoint
{
    internal class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point()
        {

        }
        public override string ToString() => $"X={X}; Y={Y} " +
            $"Name={desc.PetName};\nnID={desc.PointID}\n";

        public object Clone()
        {
            return this.MemberwiseClone();
            /*new Point(this.X, this.Y);*/
        }
    }
}
