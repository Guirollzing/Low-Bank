using LowBank.Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LowBank.Api.Controllers
{
    public class AuthenticationController : Controller
    {
        public static HashSet<string> AcessTokens = new HashSet<string>();


        private readonly IMongoCollection<Customer> _collection;

        public AuthenticationController()
        {
            var context = new MondoDbContext();
            _collection = context.Database.GetCollection<Customer>("Customer");
        }

        [HttpPost("Login", Name = "Login")]
        public async Task<IActionResult> login([FromBody] LoginModel loginModel)
        {
            if (loginModel.Login == null || string.IsNullOrWhiteSpace(loginModel.Password))
            {
                return BadRequest();
            }

            var query = await _collection.FindAsync(c => c.CPF == loginModel.Login || c.Account.Id == loginModel.Login);
            var customer = query.FirstOrDefault();

            if(customer.Password == loginModel.Password)
            {
                var acessToken = Guid.NewGuid().ToString();

                AcessTokens.Add(acessToken);
                
                return Ok(acessToken);
            }

            return BadRequest();
        }

    }
}
