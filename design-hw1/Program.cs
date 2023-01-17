namespace design_hw1
{
    public class Program
    {
        public static Queue<ICommand> commands = new Queue<ICommand>();
        
        static void Main(string[] args)
        {
            while (true)
            {
                //var command = commands.Dequeue();
                //try
                //{
                //    command.Execute();
                //}
                //catch (Exception ex)
                //{
                //    //ExceptionHandler.Handle(command, ex);
                //}
            }
        }

        public void Run(Queue<ICommand> commands)
        {
            while (commands.Count>0)
            {
                var command = commands.Dequeue();
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    ExceptionHandler.Handle(command, ex);
                }
            }
        }
    }
}