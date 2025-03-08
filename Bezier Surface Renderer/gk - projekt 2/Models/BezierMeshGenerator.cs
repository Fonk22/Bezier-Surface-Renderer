using System.Numerics;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2.Models
{
    internal static class BezierMeshGenerator
    {
        private static readonly float[][] coefficients = [[1], [1, 1], [1, 2, 1], [1, 3, 3, 1]];
        private static readonly int N = 3;
        private static readonly int M = 3;
        private static float Bernstein(int i, int n, float t)
        {
            return coefficients[n][i] * (float)Math.Pow(t, i) * (float)Math.Pow(1.0f - t, n - i);
        }
        private static Vector3 GetBezierPoint(float u, float v, ControlPoint[,] controlPoints)
        {
            Vector3 res = Vector3.Zero;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    res += controlPoints[i, j].PointOrg * Bernstein(i, N, u) * Bernstein(j, M, v);
                }
            }
            return res;
        }
        private static Vector3 GetTangentU(float u, float v, ControlPoint[,] controlPoints)
        {
            Vector3 res = Vector3.Zero;

            for (int i = 0; i <= N - 1; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    res += (controlPoints[i + 1, j].PointOrg - controlPoints[i, j].PointOrg)
                        * Bernstein(i, N - 1, u) * Bernstein(j, M, v);
                }
            }

            return N * res;
        }
        private static Vector3 GetTangentV(float u, float v, ControlPoint[,] controlPoints)
        {
            Vector3 res = Vector3.Zero;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M - 1; j++)
                {
                    res += (controlPoints[i, j + 1].PointOrg - controlPoints[i, j].PointOrg)
                        * Bernstein(i, N, u) * Bernstein(j, M - 1, v);
                }
            }
            return M * res;
        }
        public static PolygonMesh GenerateMesh(ControlPoint[,] controlPoints, int resolution)
        {
            PolygonMesh mesh = new PolygonMesh(resolution);

            float u = 0;
            float v = 0;
            float d = 1.0f / (resolution - 1);

            for (int i = 0; i < resolution; i++)
            {
                v = 0;
                for (int j = 0; j < resolution; j++)
                {
                    Vector3 point = GetBezierPoint(u, v, controlPoints);
                    Vector3 Pu = GetTangentU(u, v, controlPoints);
                    Vector3 Pv = GetTangentV(u, v, controlPoints);

                    Pu = Vector3.Normalize(Pu);
                    Pv = Vector3.Normalize(Pv);
                    Vector3 N = Vector3.Cross(Pu, Pv);
                    N = Vector3.Normalize(N);

                    mesh.Vertices[i, j] = new Vertex(u, v, point, Pu, Pv, N);

                    v += d;
                }
                u += d;
            }

            for (int i = 0; i < mesh.Vertices.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < mesh.Vertices.GetLength(1) - 1; j++)
                {
                    Vertex V1 = mesh.Vertices[i, j];
                    Vertex V2 = mesh.Vertices[i + 1, j];
                    Vertex V3 = mesh.Vertices[i, j + 1];
                    Vertex V4 = mesh.Vertices[i + 1, j + 1];

                    mesh.Triangles.Add(new Triangle(V1, V2, V3));
                    mesh.Triangles.Add(new Triangle(V2, V3, V4));
                }
            }

            return mesh;
        }
    }
}
