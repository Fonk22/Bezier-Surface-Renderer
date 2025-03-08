using System.Numerics;
using gk___projekt_2.Models;
using gk___projekt_2.Models.Core;

namespace gk___projekt_2
{
    internal static class LambertColorCalculator
    {
        public static (float alpha, float beta, float gamma) CalculateBarycentric(float x, float y, Triangle triangle)
        {
            Vector3 A = triangle.P1.PointRot;
            Vector3 B = triangle.P2.PointRot;
            Vector3 C = triangle.P3.PointRot;

            float denominator = (B.Y - C.Y) * (A.X - C.X) + (C.X - B.X) * (A.Y - C.Y);

            float alpha = ((B.Y - C.Y) * (x - C.X) + (C.X - B.X) * (y - C.Y)) / denominator;
            float beta = ((C.Y - A.Y) * (x - C.X) + (A.X - C.X) * (y - C.Y)) / denominator;
            float gamma = 1 - alpha - beta;

            return (alpha, beta, gamma);
        }

        public static InterpolatedData Interpolate(float x, float y, Triangle triangle)
        {
            InterpolatedData data = new InterpolatedData();
            (float alpha, float beta, float gamma) = CalculateBarycentric(x, y, triangle);
            float z = alpha * triangle.P1.PointRot.Z + beta * triangle.P2.PointRot.Z + gamma * triangle.P3.PointRot.Z;


            data.Position = new Vector3(x, y, z);
            data.Normal = alpha * triangle.P1.VectorNormRot + beta * triangle.P2.VectorNormRot + gamma * triangle.P3.VectorNormRot;
            data.U = alpha * triangle.P1.U + beta * triangle.P2.U + gamma * triangle.P3.U;
            data.V = alpha * triangle.P1.V + beta * triangle.P2.V + gamma * triangle.P3.V;
            data.Pu = alpha * triangle.P1.VectorPuRot + beta * triangle.P2.VectorPuRot + gamma * triangle.P3.VectorPuRot;
            data.Pv = alpha * triangle.P1.VectorPvRot + beta * triangle.P2.VectorPvRot + gamma * triangle.P3.VectorPvRot;

            return data;
        }

        public static void ModifieNormalVector(InterpolatedData data, Texture texture)
        {
            Color color = texture.GetNormalMapColor(data.U, data.V);
            float Nx = color.R / 127.0f - 1.0f;
            float Ny = color.G / 127.0f - 1.0f;
            float Nz = color.B / 127.0f - 1.0f;

            float x = data.Pu.X*Nx + data.Pv.X*Ny + data.Normal.X*Nz;
            float y = data.Pu.Y*Nx + data.Pv.Y*Ny + data.Normal.Y*Nz;
            float z = data.Pu.Z*Nx + data.Pv.Z*Ny + data.Normal.Z*Nz;
            data.Normal = Vector3.Normalize(new Vector3(x,y,z));
        }
        public static Color CalculatePixelColor(int x, int y, Triangle triangle, BezierSurface surface, LightSource lightSource)
        {
            InterpolatedData interpolatedValues = Interpolate(x, y, triangle);
            if (surface.Texture.HasNormalMap()) { ModifieNormalVector(interpolatedValues, surface.Texture); }

            Vector3 point = interpolatedValues.Position;
            Vector3 N = interpolatedValues.Normal;
            Vector3 L = lightSource.Position - point;
            L = Vector3.Normalize(L);

            float cos1 = Vector3.Dot(N, L);

            Vector3 V = Vector3.UnitZ;
            Vector3 R = 2 * cos1 * N - L;
            R = Vector3.Normalize(R);

            float cos2 = Vector3.Dot(V, R);

            cos1 = cos1 < 0.0f ? 0 : cos1;
            cos2 = cos2 < 0.0f ? 0 : cos2;
            float cos2Pow = (float)Math.Pow(cos2, surface.M);

            Color textureColor = surface.Texture.GetTextureColor(interpolatedValues.U, interpolatedValues.V);

            float surfaceRed = textureColor.R / 255.0f;
            float surfaceGreen = textureColor.G / 255.0f;
            float surfaceBlue = textureColor.B / 255.0f;

            Color lightColor = lightSource.LightColor;
            float lightRed = lightColor.R / 255.0f;
            float lightGreen = lightColor.G / 255.0f;
            float lightBlue = lightColor.B / 255.0f;

            if (lightSource.isReflector)
            {
                Vector3 lightPosition = Vector3.Normalize(lightSource.Position);
                float cos3 = Vector3.Dot(L, lightPosition);
                cos3 = cos3 < 0.0f ? 0 : cos3;
                float cos3Pow = (float)Math.Pow(cos3, lightSource.MValue);
                lightRed *= cos3Pow;
                lightGreen *= cos3Pow;
                lightBlue *= cos3Pow;         
            }

            float Ir = surface.Kd * lightRed * surfaceRed * cos1 + surface.Ks * lightRed * surfaceRed * cos2Pow;
            float Ig = surface.Kd * lightGreen * surfaceGreen * cos1 + surface.Ks * lightGreen * surfaceGreen * cos2Pow;
            float Ib = surface.Kd * lightBlue * surfaceBlue * cos1 + surface.Ks * lightBlue * surfaceBlue * cos2Pow;

            Ir = Math.Clamp(Ir * 255.0f, 0, 255);
            Ig = Math.Clamp(Ig * 255.0f, 0, 255);
            Ib = Math.Clamp(Ib * 255.0f, 0, 255);

            return Color.FromArgb((int)Ir, (int)Ig, (int)Ib);
        }
    }
}
