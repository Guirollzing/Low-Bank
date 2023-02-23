using LowBank.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace LowBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpGet(Name = "GetAccount")]
        public IEnumerable<Account> Get()
        {
            var listaDeContas = new List<Account>();

            listaDeContas.Add(new Account(10, 100, 1000));

            listaDeContas.Add(new Account(20, 200, 2000));

            return listaDeContas;
        }
    }
}
