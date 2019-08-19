using LojaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaApp.Controllers
{
    public class LojaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            string nome = produto.Nome;
            string descricao = produto.Descricao;
            decimal preco = produto.Preco;

            return View();
        }
    }
}