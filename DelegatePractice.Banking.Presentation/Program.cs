using DelegatePractice.Banking.Application;
using DelegatePractice.Banking.Application.Realizations;
using DelegatePractice.Banking.Domain;
using DelegatePractice.Banking.Infrastructure;


var accountHandler = new AccountHandler(new ConsoleMessageAction());
var repository = new AccountRepository(new List<Account>());

var account1 = new Account(accountHandler?.AccountDelegate!, 100, "Ryan Gosling");
var account2 = new Account(accountHandler?.AccountDelegate!,200, "Anders Hejlsberg");
var account3 = new Account(accountHandler?.AccountDelegate!,150, "Keanu Reeves"); 

account1.Put(100);
account2.Take(100);
account2.Take(200);

repository.Add(account1);
repository.Add(account2);
repository.Add(account3);




