using gk___projekt_2.Configuration;
using gk___projekt_2.FastGraphics;
using gk___projekt_2.Models;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2.Rendering
{
    internal static class BezierSurfaceRenderer
    {
        public static bool DrawPolygonMesh { get; set; }
        public static bool DrawControlPoints { get; set; }

        private static void RenderControlPointGrid(DirectGraphics graphics, ControlPoint[,] controlPoints)
        {
            for (int i = 0; i < controlPoints.GetLength(0); i++)
            {
                for (int j = 0; j < controlPoints.GetLength(1) - 1; j++)
                {
                    graphics.DrawLineBetweenControlPoints(DrawingConfig.ControlPointEdgeColor, controlPoints[i, j], controlPoints[i, j + 1]);
                }
            }

            for (int j = 0; j < controlPoints.GetLength(1); j++)
            {
                for (int i = 0; i < controlPoints.GetLength(0) - 1; i++)
                {
                    graphics.DrawLineBetweenControlPoints(DrawingConfig.ControlPointEdgeColor, controlPoints[i, j], controlPoints[i + 1, j]);
                }
            }

            foreach (ControlPoint v in controlPoints)
            {
                graphics.DrawControlPoint(DrawingConfig.ControlPointColor, v);
            }

        }
        private static void RenderPolygonMesh(DirectGraphics graphics, PolygonMesh mesh)
        {
            Parallel.ForEach(mesh.Triangles, triangle => 
            { 
                graphics.DrawTriangle(DrawingConfig.TriangleEdgeColor, triangle); 
            });
        }

        private static void ColorPolygonfMesh(DirectGraphics graphics, BezierSurface surface, LightSource lightSource)
        {       
            Parallel.ForEach(surface.Mesh.Triangles, triangle =>
            {
                graphics.FillTriangle(triangle, surface, lightSource);
            });
        }
        public static void Render(BezierSurface surface, DirectBitmap DirectBitmap, LightSource lightSource)
        {
            using Graphics graphics1 = Graphics.FromImage(DirectBitmap.Bitmap);
            graphics1.Clear(Color.White);

            using DirectGraphics graphics = new DirectGraphics(DirectBitmap);
            if (DrawControlPoints) { RenderControlPointGrid(graphics, surface.ControlPoints); }
            ColorPolygonfMesh(graphics, surface, lightSource);
            if (DrawPolygonMesh) { RenderPolygonMesh(graphics, surface.Mesh); }

        }
    }
}
