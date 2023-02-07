using LowBank.Windows.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowBank.Windows.Data
{
    internal class SQLCustomerRepository : BaseCustomerRepository
    {
        readonly SQLiteConnection _connection;

        public SQLCustomerRepository()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LowBankData.db");
            _connection = new SQLiteConnection(databasePath);

        }

        public override void LoadData()
        {
            _connection.CreateTable<Customer>();
            _connection.CreateTable<Account>();
        }

        public override bool Exists(long accountId)
        {
            Customer customer = _connection.Find<Customer>(c => c.CPF == accountId || c.AccountId == accountId);

            return customer != null;
        }

        public override Customer GetCustomerOrDefault(long accountId)
        {
            Customer customer = _connection.Find<Customer>(c => c.CPF == accountId || c.AccountId == accountId);

            if (customer != null)
            {
                customer.Account = _connection.Get<Account>(a => a.Id == customer.AccountId);
            }

            return customer;
        }

        public override void UpDate(params Customer[] customers)
        {
            int customersAlterados = _connection.UpdateAll(customers);

            var accounts = customers.Select(c => c.Account);

            int contasAlteradas = _connection.UpdateAll(accounts);
        }

        public override int Save(Customer customer)
        {
            
            if (customer.Account == null)
            {                
                customer.Account = new Account();
            }

            
            _connection.Insert(customer.Account);
            
            customer.AccountId = customer.Account.Id;
            
            _connection.Insert(customer);

            return customer.AccountId;
        }
    }
}
