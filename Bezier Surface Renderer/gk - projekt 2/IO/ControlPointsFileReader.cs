using gk___projekt_2.Models.Core;

namespace gk___projekt_2.IO
{
    internal static class ControlPointsFileReader
    {
        public static List<ControlPoint> ReadFromFile(string filename)
        {
            List<ControlPoint> points = new List<ControlPoint>();
            using StreamReader reader = new StreamReader(filename);
            string? line;
            while ((line = reader.ReadLine()) is not null)
            {
                string[] array = line.Split([]);
                points.Add(new ControlPoint(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2])));
            }
            return points;
        }
    }
}
