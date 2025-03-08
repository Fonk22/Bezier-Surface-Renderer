using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk___projekt_2
{
    internal class WaveFunction
    {
        public float A {  get; set; }
        public float Lambda { get; set; }
        public float Freaquency {  get; set; }

        private float kx;
        private float ky;
        private float omega;

        public WaveFunction(float a, float lambda, float freaquency)
        {
            A = a;
            Lambda = lambda;
            Freaquency = freaquency;

            kx = 2.0f * (float)Math.PI / Lambda;
            ky = 2.0f * (float)Math.PI / Lambda;
            omega = 2.0f * (float)Math.PI * freaquency;
        }

        public float CalculateZ(float x, float y, float t)
        {
            return A * (float)Math.Sin(kx*x + ky*y - omega*t);
        }
    }
}
