using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public  class ExceptionHandler
    {
        public static Dictionary<string, Action<ICommand, Exception>> CommandsHandler = new Dictionary<string, Action<ICommand, Exception>>();

        
        public static void Handle(ICommand command, Exception ex)
        {
            var action = CommandsHandler[command.GetType().ToString()];
            if (action != null) action(command, ex);

        }

        public static void Setup(string command, Action<ICommand, Exception> action)
        {
            CommandsHandler.Add(command, action);
        }
    }
}
