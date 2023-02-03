using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowBank.Windows.Models;

namespace LowBank.Windows.Data
{
    public class CustomerRepository
    {
        const string DATABASE_FILE_PATH = @"C:\Users\Guilherme\Documents\GitHub\Low-Bank\LowBank.Windows\dados.csv";
        const string DATABASE_HEADER = "Numero Conta, Cliente, CPF, Email, Telefone, Saldo";
        private List<Customer> clientes;

        public CustomerRepository()
        {
            clientes = new List<Customer>();
        }

        public void LoadData()
        {
            CreatDatabase();
            string[] lines = File.ReadAllLines(DATABASE_FILE_PATH);

            for (int i = 1; i < lines.Length; i++)
            {
                Customer novoCliente = Customer.Parse(lines[i]);
                clientes.Add(novoCliente);
            }
        }

        public Customer GetCustomerOrDefault(long indentificationNumber)
        {
            return clientes.FirstOrDefault(c => c.CPF == indentificationNumber || c.Account.Id == indentificationNumber);
        }

        public bool Exists(long CPF)
        {
            return clientes.Any(c => c.CPF == CPF);
        }

        public int GetLastId()
        {
            var ultimoId = 0;

            if (clientes.Count > 0)
            {
                var ultimoCliente = clientes.Last();
                ultimoId = ultimoCliente.Account.Id;
            }
            return ultimoId;
        }

        public int Save(Customer customer)
        {
            var novoNumeroConta = GetLastId() + 1;

            if (customer.Account == null)
            {
                Account NewAccount = new Account(novoNumeroConta, 0, 0);
                customer.Account = NewAccount;
            }

            string customerString = customer.ToString();
            File.AppendAllText(DATABASE_FILE_PATH, customerString);

            return customer.Account.Id;
        }
        internal void UpDate(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                int index = clientes.IndexOf(customer);

                clientes[index] = customer;
            }

            File.Delete(DATABASE_FILE_PATH);
            CreatDatabase();

            foreach (var cliente in clientes)
            {
                Save(cliente);
            }
        }
        private void CreatDatabase()
        {
            if (File.Exists(DATABASE_FILE_PATH))
                return;

            File.WriteAllText(DATABASE_FILE_PATH, DATABASE_HEADER);

        }


    }
}
