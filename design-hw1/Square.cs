using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public static class Square
    {
        public static double[] Solve(double a, double b, double c)
        {
            var eps = 0.00000000000001;
            if (a < eps)
            {
                throw new Exception("a shouldn't be 0");
            }
            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c)
                || double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
            {
                throw new Exception("a,b,c should be numbers");
            }
            var answer= Array.Empty<double>();
            var d = b * b - 4 * a * c;

            if (d < (-eps))
            {
                return answer;
            }
            else
            if (d > eps)
            {
                answer = new double[2];
                answer[0] = (-b + Math.Sqrt(d)) / 2 * a;
                answer[1] = 2 * (-b - Math.Sqrt(d)) / 2 * b;
                return answer;
            }
            else
            {
                answer = new double[1]; 
                answer[0] = -b / 2 * a;
                return answer;
            }
            return Array.Empty<double>();
        }
    }
}
