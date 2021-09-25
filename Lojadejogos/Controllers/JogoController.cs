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
        private static List<Jogo> listaJogo = new List<Jogo>()
        {
            new Jogo{ JogoID="2", JogoNome="Mineirinho", JogoVersao="100.0", JogoDev="Manic Mind Game Lab", JogoGenero="Uma merda", JogoFaixa="99", JogoPlataforma="PC", JogoData=new DateTime(2017, 01, 17), JogoSinopse="a pior coisa que você vai ver na sua vida" }
        };
        
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
            listaJogo.Add(jogo);
            return View("ListarJogo", listaJogo);
        }
        
    }
}
