using Microsoft.AspNetCore.Mvc;
using JhoniesAT_6.Models;

namespace JhoniesAT_6.Controllers
{
    public class dados_clientesController : Controller
    {
        private static List<dados_clientes> listaclientes = new List<dados_clientes>();

        public IActionResult Index(string busca)
        {
            var resultado = listaclientes;

            if (!string.IsNullOrEmpty(busca))
            {
                busca = busca.ToLower();

                resultado = listaclientes
                    .Where(c =>
                    c.Nome.ToLower().Contains(busca) ||
                    c.CPF.ToLower().Contains(busca) ||
                    c.Email.ToLower().Contains(busca) ||
                    c.Paciente.ToLower().Contains(busca))
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

        public IActionResult Create(dados_clientes clientes)
        {
            clientes.Id = listaclientes.Count + 1;

            listaclientes .Add(clientes);

            return RedirectToAction("Index");   
        }
    }
}
