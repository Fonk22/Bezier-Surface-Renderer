namespace gk___projekt_2
{
    internal class Edge
    {
        public float YMin { get; set; }
        public float YMax { get; set; }
        public float X { get; set; }
        public float InverseSlope { get; set; }

        public Edge(Point p1, Point p2)
        {
            YMin = Math.Min(p1.Y, p2.Y);
            YMax = Math.Max(p1.Y, p2.Y);
            X = (p1.Y < p2.Y) ? p1.X : p2.X;
            InverseSlope = (p1.Y != p2.Y) ? (p2.X - p1.X) / (float)(p2.Y - p1.Y) : 0;
        }
    }
}
