using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[ListarProdutos]")]
    public class ProdutoController : Controller
    {
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok("Método Funcionou");
        }
    }
}
