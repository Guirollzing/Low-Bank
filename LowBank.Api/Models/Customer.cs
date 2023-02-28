using MongoDB.Bson.Serialization.Attributes;

namespace LowBank.Api.Models
{
    public class Customer
    {
        [BsonId]
        public long CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }        
        public long Telefone { get; set; }
        public Account Account { get; set; }

        public Customer(string name, string email, long cpf, long telefone)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
        }

        public Customer()
        {

        }

    }
}
