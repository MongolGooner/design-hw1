using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public class Move
    {
        IMovable MovableObject;

        public Move(IMovable movableObject)
        {
            this.MovableObject = movableObject;
        }

        public void Execute()
        {
            MovableObject.Position = Vector.Add(MovableObject.Position, MovableObject.Velocity);
        }
    }
}
