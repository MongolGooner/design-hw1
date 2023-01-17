using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public class ExceptionHandler : IExceptionHandler
    {
        public Dictionary<string, Action<ICommand, Exception>> CommandsHandler;

        public ExceptionHandler()
        {
            CommandsHandler = new Dictionary<string, Action<ICommand, Exception>>();
        }
        public void Handle(ICommand command, Exception ex)
        {
            var action = CommandsHandler[command.GetType().ToString()];
            if (action != null) action(command, ex);

        }

        public void Setup(string command, Action<ICommand, Exception> action)
        {
            CommandsHandler.Add(command, action);
        }
    }
}
