namespace gk___projekt_2.Models.Core
{
    internal class Triangle
    {
        public readonly Vertex P1;
        public readonly Vertex P2;
        public readonly Vertex P3;

        public Triangle(Vertex P1, Vertex P2, Vertex P3)
        {
            this.P1 = P1;
            this.P2 = P2;
            this.P3 = P3;
        }
    }
}
