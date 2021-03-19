using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    public class Formuls
    {

        const double dt = 0.1;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        public double a;
        public double v0;
        public double y0;
        public double m;
        public double S;
        public double k;

        public double t;
        public double x;
        public double y;
        public double vx;
        public double vy;

        public void makeValue(double edAngle, double edSpeed, double edHeight, double edWeight, double edSquare)
        {
            a = edAngle; 
            v0 = edSpeed;
            y0 = edHeight;
            m = edWeight;
            S = edSquare;
            k = 0.5 * C * S * rho / m;
        }

        public void Position()
        {
            vx = v0 * Math.Cos(a * Math.PI / 180);
            vy = v0 * Math.Sin(a * Math.PI / 180);
            t = 0;
            x = 0;
            y = y0;
        }
       
        public void main()
        {
            t += dt;
            vx = vx - k * vx * Math.Sqrt(vx * vx + vy * vy) * dt;
            vy = vy - (g + k * vy * Math.Sqrt(vx * vx + vy * vy)) * dt;

            x = x + vx * dt;
            y = y + vy * dt;
        }

    }
}
