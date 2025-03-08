using gk___projekt_2.Models;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2.FastGraphics
{
    internal class DirectGraphics : IDisposable
    {
        private readonly DirectBitmap directBitmap;
        private bool disposed = false;

        public DirectGraphics(DirectBitmap bitmap) { directBitmap = bitmap; }

        private int TransformXCoordinate(int x)
        {
            return x + directBitmap.Width / 2;
        }
        private int TransformYCoordinate(int y)
        {
            return directBitmap.Height / 2 - y;
        }
        private void TransformCoordinates(ref int x, ref int y)
        {
            x = TransformXCoordinate(x);
            y = TransformYCoordinate(y);
        }

        // source: https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm
        public void DrawLine(Color color, float x0, float y0, float x1, float y1)
        {
            int x0Int = (int)x0;
            int y0Int = (int)y0;
            int x1Int = (int)x1;
            int y1Int = (int)y1;

            TransformCoordinates(ref x0Int, ref y0Int);
            TransformCoordinates(ref x1Int, ref y1Int);

            if (Math.Abs(y1Int - y0Int) < Math.Abs(x1Int - x0Int))
            {
                if (x0Int > x1Int) { DrawLineLow(color, x1Int, y1Int, x0Int, y0Int); }
                else { DrawLineLow(color, x0Int, y0Int, x1Int, y1Int); }
            }
            else
            {
                if (y0Int > y1Int) { DrawLineHigh(color, x1Int, y1Int, x0Int, y0Int); }
                else { DrawLineHigh(color, x0Int, y0Int, x1Int, y1Int); }
            }
        }
        private void DrawLineLow(Color color, int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y0;
            for (int x = x0; x < x1; x++)
            {
                directBitmap.SafeSetPixel(x, y, color);
                if (D > 0)
                {
                    y += yi;
                    D += 2 * (dy - dx);
                }
                else { D += 2 * dy; }
            }
        }

        private void DrawLineHigh(Color color, int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x0;
            for (int y = y0; y < y1; y++)
            {
                directBitmap.SafeSetPixel(x, y, color);
                if (D > 0)
                {
                    x += xi;
                    D += 2 * (dx - dy);
                }
                else
                {
                    D += 2 * dx;
                }

            }
        }

        public void DrawRectangle(Color color, float x, float y, float width, float height)
        {
            DrawLine(color, x, y, x + width, y);
            DrawLine(color, x, y, x, y - height);
            DrawLine(color, x + width, y, x + width, y - height);
            DrawLine(color, x, y - height, x + width, y - height);
        }

        public void FillRectangle(Color color, float x, float y, float width, float height)
        {
            int xInt = (int)x;
            int yInt = (int)y;

            TransformCoordinates(ref xInt, ref yInt);

            for (int i = xInt; i < xInt + (int)width; i++)
            {
                for (int j = yInt; j < yInt + (int)height; j++)
                {
                    directBitmap.SafeSetPixel(i, j, color);
                }
            }
        }
        public void Clear(Color color)
        {
            for(int i=0; i<directBitmap.Width; i++)
            {
                for(int j=0; j<directBitmap.Height; j++)
                {
                    directBitmap.SafeSetPixel(i,j,color);
                }
            }
        }

        public List<Edge> BucketSortEdges(List<Edge> edges)
        {
            int minY = (int)edges.Min(e => e.YMin);
            int maxY = (int)edges.Max(e => e.YMin);

            List<List<Edge>> buckets = new List<List<Edge>>(maxY - minY + 1);
            for (int i = 0; i <= maxY - minY; i++)
            {
                buckets.Add(new List<Edge>());
            }

            foreach (Edge edge in edges)
            {
                int bucketIndex = (int)(edge.YMin - minY);
                buckets[bucketIndex].Add(edge);
            }

            foreach (var bucket in buckets)
            {
                bucket.Sort((e1, e2) => e1.X.CompareTo(e2.X));
            }

            List<Edge> sortedEdges = new List<Edge>();
            foreach (var bucket in buckets)
            {
                sortedEdges.AddRange(bucket);
            }

            return sortedEdges;
        }
        public void FillTriangle(Triangle triangle, BezierSurface surface, LightSource lightSource)
        {

            List<Point> polygon = new List<Point>()
            {
                new Point((int)triangle.P1.PointRot.X, (int)triangle.P1.PointRot.Y),
                new Point((int)triangle.P2.PointRot.X, (int)triangle.P2.PointRot.Y),
                new Point((int)triangle.P3.PointRot.X, (int)triangle.P3.PointRot.Y)
            };


            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < polygon.Count; i++)
            {
                Edge edge = new Edge(polygon[i], polygon[(i + 1) % polygon.Count]);
                if (edge.YMin != edge.YMax)
                {
                    edges.Add(new Edge(polygon[i], polygon[(i + 1) % polygon.Count]));
                }
            }
            if(edges.Count == 0) { return; }

            edges = BucketSortEdges(edges);
            int edgesIterator = 0;

            List<Edge> activeEdges = new List<Edge>();
            float currentY = edges[0].YMin;

            for (int y = (int)currentY; y < edges.Max(e => e.YMax); y++)
            {
                activeEdges.RemoveAll(e => e.YMax <= y);

                while (edgesIterator < edges.Count && edges[edgesIterator].YMin == y)
                {
                    activeEdges.Add(edges[edgesIterator]);
                    edgesIterator += 1;
                }

                activeEdges = activeEdges.OrderBy(e => e.X).ToList();

                for (int i = 0; i < activeEdges.Count - 1; i += 2)
                {
                    Edge edge1 = activeEdges[i];
                    Edge edge2 = activeEdges[i + 1];
                    if (edge1.X != edge2.X)
                    {
                        for(int x = (int)edge1.X; x <= (int)edge2.X; x++)
                        {
                            Color color = LambertColorCalculator.CalculatePixelColor(x, y, triangle, surface, lightSource);
                            directBitmap.SafeSetPixel(TransformXCoordinate(x), TransformYCoordinate(y), color);
                        }
                    }
                }

                foreach (Edge edge in activeEdges)
                {
                    edge.X += edge.InverseSlope;
                }
            }
        }
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}
