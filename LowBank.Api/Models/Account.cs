namespace LowBank.Api.Models
{
    public class Account
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public int Limit { get; set; }

        public Account(long id, decimal amount, int limit)
        {
            Id = id;
            Amount = amount;
            Limit = limit;
        }
    }
}
