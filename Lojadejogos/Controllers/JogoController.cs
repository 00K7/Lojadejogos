using Lojadejogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lojadejogos.Controllers
{

    public class JogoController : Controller
    {
        
        
    // GET: Jogo
    public ActionResult Index()
        {
            var jogo = new Jogo();
            return View();
        }
        Acoes ac = new Acoes();
        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            ac.CadastrarFuncionario(jogo);
            return View(jogo);
        }
        
    }
}
