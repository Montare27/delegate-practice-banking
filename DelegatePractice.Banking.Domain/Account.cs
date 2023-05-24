namespace DelegatePractice.Banking.Domain
{
    public class Account
    {

        public Account(Action<string> del, decimal sum = 0, string name = "")
        {
            Sum = sum;
            Name = name;
            Notify += del;
        }

        public event Action<string>? Notify;
        public Guid Id { get; set; }
        public decimal Sum { get; set; }
        public string Name { get; set; }

        public void Put(decimal sum)
        {
            Sum += sum;
            Notify?.Invoke($"{sum}$ was added on your wallet");
        }
        
        public void Take(decimal sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                Notify?.Invoke($"{sum}$ was taken from your wallet");
            }
            else
            {
                Notify?.Invoke($"Not enough money on your waller");
            }
        }
    }
}
