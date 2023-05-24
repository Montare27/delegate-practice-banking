namespace DelegatePractice.Banking.Application
{
    using Domain;
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
