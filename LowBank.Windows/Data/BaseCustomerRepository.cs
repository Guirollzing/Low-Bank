using LowBank.Windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowBank.Windows.Data
{
    public abstract class BaseCustomerRepository
    {
        public abstract void LoadData();

        public abstract Customer GetCustomerOrDefault(long account);

        public abstract bool Exists(long account);

        public abstract int Save(Customer customer);

        public abstract void UpDate(params Customer[] customers);
        public abstract bool Login(LoginModel loginModel);

    }
}
