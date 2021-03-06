﻿using Microsoft.AspNetCore.Mvc;
using Pedrinho.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pedrinho.Controllers
{
    public class HomeController : Controller
    {
        private readonly PedrinhoContext _context;

        public HomeController(PedrinhoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Index(Usuario usuario)          
             
        {
           
        Usuario usuarioLogado = _context.Usuario.Where(x => x.nome == usuario.nome && x.senha == usuario.senha).FirstOrDefault();

                if (usuarioLogado != null)
                {
                    if (usuarioLogado.tipoAcesso == "admin")
                    {
                        return RedirectToAction("Index", "Usuario");
                    }

                    if (usuarioLogado.tipoAcesso == "moderador")
                    {
                        return RedirectToAction("Index", "Bug");
                    }

                if (usuarioLogado.tipoAcesso == "user")
                {
                    return RedirectToAction("Enigma", "Enigma");
                }

            }

            ModelState.AddModelError("nome", "Usuario ou senha invalida");

            return View();
        }

        public async Task<IActionResult> Final(Usuario usuario)

        {
            return View();

        }

            public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
