namespace Banking_Application.Realizations
{
    using Interfaces;

    public class ConsoleMessageAction : IMessageAction
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
