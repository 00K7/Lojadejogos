using Lojadejogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lojadejogos.Controllers
{
    public class ClienteController : Controller
    {
       
        };
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View();
        }
        Acoes ac = new Acoes();
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            ac.CadastrarFuncionario(cliente);
            return View(cliente);
        }


    }
}
