using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string texto = "API Funcionou";
            return Ok(texto);
        }
        [HttpGet("Home1")]
        public IActionResult Index1()
        {
            string texto = "API Funcionou1";
            return Ok(texto);
        }
    }
}
