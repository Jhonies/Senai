using Microsoft.AspNetCore.Mvc;
using JhoniesAT_6.Models;

namespace JhoniesAT_6.Controllers
{
    public class dados_fornecedoresController : Controller
    {
        private static List<dados_fornecedores> listafornecedores = new List<dados_fornecedores>();

        public IActionResult Index(string busca)
        {
            var resultado = listafornecedores;

            if (!string.IsNullOrEmpty(busca))
            {
                busca = busca.ToLower();

                resultado = listafornecedores
                    .Where(c =>
                    c.Nome_f.ToLower().Contains(busca) ||
                    c.CNPJ.ToLower().Contains(busca) ||
                    c.Email_f.ToLower().Contains(busca))
                    .ToList();
            }
            return View(resultado);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(dados_fornecedores fornecedores)
        {
            fornecedores.Id_f = listafornecedores.Count + 1;

            listafornecedores.Add(fornecedores);

            return RedirectToAction("Index");
        }
    }
}