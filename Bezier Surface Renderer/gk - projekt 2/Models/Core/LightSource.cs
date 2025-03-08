using System.Numerics;

namespace gk___projekt_2
{
    internal class LightSource
    {
        public Vector3 Position { get; set; }
        public Color LightColor { get; set; }
        public bool isReflector { get; set; }

        public int MValue { get; set; }

        public LightSource(Vector3 position, Color lightColor)
        {
            Position = position;
            LightColor = lightColor;
            isReflector = false;
            MValue = 1;
        }
        public LightSource(float x, float y, float z, Color lightColor) : this(new Vector3(x, y,z), lightColor) { }

        public void Rotate(Quaternion rotation)
        {
            Position = Vector3.Transform(Position, rotation);
        }
        public void ChangeZCoordinate(float newZ)
        {
            Position = new Vector3(Position.X, Position.Y, newZ);
        }
    }
}
