namespace design_hw1
{
    public interface IExceptionHandler
    {
        void Handle(ICommand command, Exception ex);
        void Setup(string command, Action<ICommand, Exception> action);
    }
}