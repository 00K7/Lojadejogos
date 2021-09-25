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
        private static List<Cliente> listaCliente = new List<Cliente>() {
            new Cliente{ ClienteCPF="1894017348", ClienteNome="Oxe", ClienteDataNascimento= new DateTime(2000, 06, 15), ClienteEmail="xswzaq@gmail.com", ClienteCelular="23083-6173", ClienteEndereco="Rua Sebastião de Paiva, 83"}
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
            listaCliente.Add(cliente);
            return View("ListarCliente", listaCliente);
        }


    }
}
