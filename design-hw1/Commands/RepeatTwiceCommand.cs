using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public class RepeatTwiceCommand : ICommand
    {
        public ICommand command;    
        public RepeatTwiceCommand(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Execute();
        }
    }
}
