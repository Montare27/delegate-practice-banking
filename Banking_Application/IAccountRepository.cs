namespace Banking_Application
{
    using Banking_Domain;

    public interface IAccountRepository
    {
        void Add(Account account);

        void Update(Account account);
        
        void Delete(Guid id);
        
        Account? Get(Guid id);

        List<Account>? GetAll();
    }
}
