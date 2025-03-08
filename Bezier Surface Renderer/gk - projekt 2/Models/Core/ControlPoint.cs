using System.Numerics;

namespace gk___projekt_2.Models.Core
{
    internal class ControlPoint
    {
        public Vector3 PointOrg;
        public Vector3 PointRot;
        public ControlPoint(Vector3 point)
        {
            PointOrg = point;
            PointRot = point;
        }
        public ControlPoint(float x, float y, float z) : this(new Vector3(x, y, z)) { }

        public void Rotate(Quaternion rotation1)
        {
            PointRot = Vector3.Transform(PointOrg, rotation1);
        }
    }
}
