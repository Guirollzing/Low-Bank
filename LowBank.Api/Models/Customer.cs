namespace LowBank.Api.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long CPF { get; set; }
        public long Telefone { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }

        public Customer(string name, string email, long cPF, long telefone, int accountId)
        {
            Name = name;
            Email = email;
            CPF = cPF;
            Telefone = telefone;
            AccountId = accountId;
        }

    }
}
