using System.Numerics;

namespace gk___projekt_2.Models.Core
{
    internal class Vertex
    {
        public readonly float U;
        public readonly float V;
        public readonly Vector3 PointOrg;
        public readonly Vector3 VectorPuOrg;
        public readonly Vector3 VectorPvOrg;

        public Vector3 VectorNormOrg { get; set; }
        public Vector3 PointRot { get; private set; }
        public Vector3 VectorPuRot { get; private set; }
        public Vector3 VectorPvRot { get; private set; }
        public Vector3 VectorNormRot { get; private set; }

        public Vertex(float u, float v, Vector3 pointOrg, Vector3 vectorPuOrg, Vector3 vectorPvOrg, Vector3 vectorNormOrg)
        {
            U = u;
            V = v;
            PointOrg = pointOrg;
            VectorPuOrg = vectorPuOrg;
            VectorPvOrg = vectorPvOrg;
            VectorNormOrg = vectorNormOrg;
            PointRot = pointOrg;
            VectorPuRot = vectorPuOrg;
            VectorPvRot = vectorPvOrg;
            VectorNormRot = vectorNormOrg;
        }
        public void Rotate(Quaternion rotation)
        {
            PointRot = Vector3.Transform(PointOrg, rotation);
            VectorPuRot = Vector3.Transform(VectorPuOrg, rotation);
            VectorPvRot = Vector3.Transform(VectorPvOrg, rotation);
            VectorNormRot = Vector3.Transform(VectorNormOrg, rotation);
        }
    }
}
