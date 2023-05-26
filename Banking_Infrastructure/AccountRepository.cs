namespace Banking_Infrastructure
{
    using Banking_Application;
    using Banking_Domain;

    public class AccountRepository : IAccountRepository
    {
        private List<Account> _accounts { get; set; }

        public AccountRepository(List<Account> accounts) => _accounts = accounts;

        public void Add(Account account)
        {
            _accounts.Add(account);
        }

        public void Update(Account account)
        {
            var existingAccount = _accounts.FirstOrDefault(a => a.Id == account.Id);
            if (existingAccount != null)
            {
                existingAccount.Id = account.Id;
                existingAccount.Name = account.Name;
                existingAccount.Sum = account.Sum;
            }
        }

        public void Delete(Guid id)
        {
            var account = _accounts.FirstOrDefault(acc => acc.Id == id);
            if (account != null)
            {
                _accounts.Remove(account);
            }
        }

        public Account? Get(Guid id)
        {
            var account = _accounts.FirstOrDefault(acc => acc.Id == id);
            return account;
        }

        public List<Account>? GetAll()
        {
            return _accounts;
        }
    }
}
