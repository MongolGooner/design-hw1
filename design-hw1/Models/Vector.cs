using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public class Vector
    {
        private double v1;
        private double v2;

        public Vector(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            var newValue = new Vector(vector1.v1 + vector2.v1, vector1.v2 + vector2.v2);
            return newValue;
        }

        //TODO прочитать в книжке про типизацию и переписать
        //TODO прочитать про Dictionary и рассказать Власу где equals а где hash-код (разные словари)
        //Стандартный equals 
        public override bool Equals(object vector1)
        {
            return ((Vector)vector1).v1 == this.v1 && ((Vector)vector1).v2==this.v2;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Vector vector1, Vector vector2)
        {
            return vector1.v1 == vector2.v1 && vector1.v2 == vector2.v2;
        }

        public static bool operator !=(Vector vector1, Vector vector2)
        {
            return vector1.v1 != vector2.v1 || vector1.v2 == vector2.v2;
        }


    }
}
