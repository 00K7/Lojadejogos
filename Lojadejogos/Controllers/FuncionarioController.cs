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
        private static List<Funcionario> listaFuncionario = new List<Funcionario>() { 
            new Funcionario{ FuncionarioID=1, FuncionarioCPF="11111111111", FuncionarioRG="11111111111" ,FuncionarioNome="Tim Maia", FuncionarioCargo="gerente", FuncionarioDataNascimento= new DateTime(2004, 10, 20), FuncionarioEmail="qazwsx@gmail.com", FuncionarioCelular="29881-8032", FuncionarioEndereco="Rua Sebastião de Paiva, 84"}
        };
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
            listaFuncionario.Add(funcionario);
            return View("ListarFuncionario", listaFuncionario);
        }

        
    }
}
