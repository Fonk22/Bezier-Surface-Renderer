using gk___projekt_2.Configuration;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2.FastGraphics
{
    internal static class DirectGraphicsExtensions
    {
        public static void DrawControlPoint(this DirectGraphics graphics, Color color, ControlPoint point)
        {
            int center_x = (int)point.PointRot.X - DrawingConfig.ControlPointWidth / 2;
            int center_y = (int)point.PointRot.Y + DrawingConfig.ControlPointHeight / 2;
            graphics.FillRectangle(color, center_x, center_y, DrawingConfig.ControlPointWidth, DrawingConfig.ControlPointHeight);
        }
        public static void DrawLineBetweenControlPoints(this DirectGraphics graphics, Color color, ControlPoint point1, ControlPoint point2)
        {
            graphics.DrawLine(color, point1.PointRot.X, point1.PointRot.Y, point2.PointRot.X, point2.PointRot.Y);
        }
        public static void DrawTriangle(this DirectGraphics graphics, Color color, Triangle triangle)
        {
            graphics.DrawLine(color, triangle.P1.PointRot.X, triangle.P1.PointRot.Y, triangle.P2.PointRot.X, triangle.P2.PointRot.Y);
            graphics.DrawLine(color, triangle.P2.PointRot.X, triangle.P2.PointRot.Y, triangle.P3.PointRot.X, triangle.P3.PointRot.Y);
            graphics.DrawLine(color, triangle.P1.PointRot.X, triangle.P1.PointRot.Y, triangle.P3.PointRot.X, triangle.P3.PointRot.Y);
        }
    }
}
