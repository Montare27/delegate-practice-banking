namespace Application
{
    using Interfaces;
    using System;

    public class AccountHandler
    {
        public AccountHandler(IMessageAction action)
        {
            AccountDelegate = action.PrintMessage;
        }
        public Action<string>? AccountDelegate { get; set; }
    }
}
