using System.Numerics;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2.Models
{
    internal class BezierSurface
    {
        public ControlPoint[,] ControlPoints;
        public PolygonMesh Mesh;

        private float alphaRad;
        private float betaRad;
        private int resolution;
        public float Kd { get; set; }
        public float Ks { get; set; }
        public float M { get; set; }

        public float AlphaDeg
        {
            get
            {
                return alphaRad * 180.0f / (float)Math.PI;
            }
            set
            {
                alphaRad = value * (float)Math.PI / 180.0f;
                RotateSurface();
            }
        }
        public float BetaDeg
        {
            get
            {
                return betaRad * 180.0f / (float)Math.PI;
            }
            set
            {
                betaRad = value * (float)Math.PI / 180.0f;
                RotateSurface();
            }
        }

        public Texture Texture { get; set; }
        public int Resolution
        {
            get
            {
                return resolution;
            }
            set
            {
                resolution = value;
                GenerateNewMesh();
            }
        }

        public BezierSurface(List<ControlPoint> controlPoints, Texture texture,int resolution, float kd, float ks, float m)
        {
            if (controlPoints.Count != 16) { throw new ArgumentException("Bezier surface requires a 4x4 grid of control points."); }

            Kd = kd;
            Ks = ks;
            M = m;
            this.resolution = resolution;
            Texture = texture;

            ControlPoints = new ControlPoint[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ControlPoints[i, j] = controlPoints[i * 4 + j];
                }
            }

            Mesh = BezierMeshGenerator.GenerateMesh(ControlPoints, resolution);
        }
        private void GenerateNewMesh()
        {
            Mesh = BezierMeshGenerator.GenerateMesh(ControlPoints, resolution);
            RotateSurface();
        }
        private void RotateSurface()
        {
            Quaternion rotationAlpha = Quaternion.CreateFromAxisAngle(Vector3.UnitZ, alphaRad);
            Quaternion rotationBeta = Quaternion.CreateFromAxisAngle(Vector3.UnitX, betaRad);
            Quaternion rotationCombined = rotationAlpha * rotationBeta;

            foreach (ControlPoint point in ControlPoints)
            {
                point.Rotate(rotationCombined);
            }
            foreach (Vertex vertex in Mesh.Vertices)
            {
                vertex.Rotate(rotationCombined);
            }
        }
        public void WaveSurface(WaveFunction wave, float time)
        {
            foreach(ControlPoint point in ControlPoints)
            {
                point.PointOrg.Z = wave.CalculateZ(point.PointOrg.X, point.PointOrg.Y, time);
            }
            Mesh = BezierMeshGenerator.GenerateMesh(ControlPoints, resolution);
            RotateSurface();
        }
    }
}
