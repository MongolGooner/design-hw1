using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public interface IRotable
    {
        public int Direction { get; set; }

        public int DirectionsNumber { get; set; }
    }
}
