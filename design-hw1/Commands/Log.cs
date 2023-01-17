using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_hw1
{
    public class Log : ICommand
    {
        ICommand command;
        public static Logger logger = LogManager.GetCurrentClassLogger();
        Exception exception;
        public Log()
        { }
        public Log(ICommand command, Exception ex)
        {
            this.command = command;
            this.exception = ex;
        }
        public void Execute()
        {
            logger.Error($"В процессе выполнения команды {command.GetType()} произошла ошибка: { exception.ToString()}");
        }
    }
}
