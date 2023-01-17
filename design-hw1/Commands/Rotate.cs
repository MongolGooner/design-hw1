using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public  class Rotate
    {
        IRotable RotableObject;

        public Rotate(IRotable rotableObject)
        {
            this.RotableObject = rotableObject;
        }

        public void Execute(int toAdd)
        {
            RotableObject.Direction = (RotableObject.Direction + toAdd) % RotableObject.DirectionsNumber;            
        }
    }
}
