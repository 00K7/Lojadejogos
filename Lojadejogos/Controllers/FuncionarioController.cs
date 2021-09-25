using Lojadejogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lojadejogos.Controllers
{
    public class FuncionarioController : Controller
    {
        
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionario = new Funcionario();
            return View();
        }
        Acoes ac = new Acoes();
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }

        
    }
}
