using LowBank.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace LowBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController
    {
        [HttpGet(Name = "GetCustomer")]

        public IEnumerable<Customer> Get()
        {
            var customerList = new List<Customer>();

            customerList.Add(new Customer("Guilherme", "guilherme@gmail.com", 00000000000, 51986387966, 1));

            return customerList;
        }

    }
}
