using gk___projekt_2.Models.Core;

namespace gk___projekt_2
{
    internal class PolygonMesh
    {
        public Vertex[,] Vertices;
        public List<Triangle> Triangles;

        public PolygonMesh(int height = 0, int width = 0)
        {
            width = width == 0 ? height : width;
            Vertices = new Vertex[height, width];
            Triangles = new List<Triangle>();
        }

    }
}
