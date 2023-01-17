using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public interface IMovable
    {
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }
}
