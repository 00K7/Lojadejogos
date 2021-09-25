using Lojadejogos.Repos;
using MySql.Data.MySqlClient;
using Lojadejogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lojadejogos.Controllers
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
       
        public void CadastrarFuncionario(Funcionario func)
        {
            
            string data_sistema = Convert.ToDateTime(func.FuncionarioDataNascimento).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("instert into Funcionario values(@FuncionarioID,@FuncionarioCPF,@FuncionarioRg,@FuncionarioNome,@FuncionarioCargo,@FuncionarioDataNascimento, @FuncionarioEmail,@FuncionarioCelular,@FuncionarioEndereco)", con.ConectarBd());
            cmd.Parameters.Add("@FuncionarioID", MySqlDbType.VarChar).Value = func.FuncionarioID;
            cmd.Parameters.Add("@FuncionarioCPF", MySqlDbType.VarChar).Value = func.FuncionarioCPF;
            cmd.Parameters.Add("@FuncionarioRG", MySqlDbType.VarChar).Value = func.FuncionarioRG;
            cmd.Parameters.Add("@FuncionarioNome", MySqlDbType.VarChar).Value = func.FuncionarioNome;
            cmd.Parameters.Add("@FuncionarioCargo", MySqlDbType.VarChar).Value = func.FuncionarioCargo;
            cmd.Parameters.Add("@FuncionarioDataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@FuncionarioEmail", MySqlDbType.VarChar).Value = func.FuncionarioEmail;
            cmd.Parameters.Add("@FuncionarioCelular", MySqlDbType.VarChar).Value = func.FuncionarioCelular;
            cmd.Parameters.Add("@FuncionarioEndereco", MySqlDbType.VarChar).Value = func.FuncionarioEndereco;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }
        public void DeletarFuncionario(int dlt)
        {
            var comando = String.Format("delete from Funcionario where FuncionarioID = {0}", dlt);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            cmd.ExecuteReader();
        }
        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from Funcionario where FuncionarioID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFuncionario(DadosCodFunc).FirstOrDefault();
        }
        public List<Funcionario> ListarCodFuncionario(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read()) 
            {
                var AlTemp = new Funcionario()
                {
                    FuncionarioID = ushort.Parse(dt["FuncionarioID"].ToString()),
                    FuncionarioNome = dt["FuncionarioNome"].ToString(),
                    FuncionarioCargo = dt["FuncionarioCargo"].ToString(),
                    FuncionarioDataNascimento = DateTime.Parse(dt["FuncionarioDataNascimento"].ToString())
                };
                AltAl.Add(AlTemp);
                
            }
            dt.Close();
            return AltAl;

        }
        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from Funcionario", con.ConectarBd());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }
        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncionarioID = ushort.Parse(dt["FuncionarioID"].ToString()),
                    FuncionarioCPF = dt["FuncionarioCPF"].ToString(),
                    FuncionarioRG = dt["FuncionarioRG"].ToString(),
                    FuncionarioNome = dt["FuncionarioNome"].ToString(),
                    FuncionarioCargo = dt["FuncionarioCargo"].ToString(),
                    FuncionarioDataNascimento = DateTime.Parse(dt["FuncionarioDataNascimento"].ToString()),
                    FuncionarioEmail = dt["FuncionarioEmail"].ToString(),
                    FuncionarioCelular = dt["FuncionarioCelular"].ToString(),
                    FuncionarioEndereco = dt["FuncionarioEndereco"].ToString()
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;
        }

        public void CadastrarCliente(Cliente cli)
        {

            string data_sistema = Convert.ToDateTime(cli.ClienteDataNascimento).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("instert into Cliente values(@ClienteCPF,@ClienteNome,@ClienteDataNascimento,@ClienteEmail,@ClienteCelular,@ClienteEndereco)", con.ConectarBd());
            cmd.Parameters.Add("@ClienteCPF", MySqlDbType.VarChar).Value = cli.ClienteCPF;
            cmd.Parameters.Add("@ClienteNome", MySqlDbType.VarChar).Value = cli.ClienteNome;
            cmd.Parameters.Add("@ClienteDataNascimento", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@ClienteEmail", MySqlDbType.VarChar).Value = cli.ClienteEmail;
            cmd.Parameters.Add("@ClienteCelular", MySqlDbType.VarChar).Value = cli.ClienteCelular;
            cmd.Parameters.Add("@ClienteEndereco", MySqlDbType.VarChar).Value = cli.ClienteEndereco;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }
        public void DeletarCliente(int dlt)
        {
            var comando = String.Format("delete from Cliente where ClienteCPF = {0}", dlt);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            cmd.ExecuteReader();
        }
        public Cliente ListarCPFCliente(int cod)
        {
            var comando = String.Format("select * from Cliente where ClienteCPF = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosCPFcli = cmd.ExecuteReader();
            return ListarCPFCliente(DadosCPFcli).FirstOrDefault();
        }
        public List<Cliente> ListarCPFCliente(MySqlDataReader dt)
        {
            var AltAl1 = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp1 = new Cliente()
                {
                    ClienteCPF = dt["ClienteCPF"].ToString(),
                    ClienteNome = dt["ClienteNome"].ToString(),
                    ClienteDataNascimento = DateTime.Parse(dt["ClienteDataNascimento"].ToString()),
                    ClienteEmail= dt["ClienteEmail"].ToString(),
                    ClienteCelular= dt["ClienteCelular"].ToString(),
                    ClienteEndereco = dt["ClienteEndereco"].ToString()
                };
                AltAl1.Add(AlTemp1);

            }
            dt.Close();
            return AltAl1;

        }
        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from Cliente", con.ConectarBd());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }
        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosCliente = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    ClienteCPF = dt["ClienteCPF"].ToString(),
                    ClienteNome = dt["ClienteNome"].ToString(),
                    ClienteDataNascimento = DateTime.Parse(dt["ClienteDataNascimento"].ToString()),
                    ClienteEmail = dt["ClienteEmail"].ToString(),
                    ClienteCelular = dt["ClienteCelular"].ToString(),
                    ClienteEndereco = dt["ClienteEndereco"].ToString()
                };
                TodosCliente.Add(ClienteTemp);
            }
            dt.Close();
            return TodosCliente;
        }

        public void CadastrarJogo(Jogo jog)
        {

            string data_sistema = Convert.ToDateTime(jog.JogoData).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("instert into Jogo values(@JogoID,@JogoNome,@JogoVersao,@JogoDev,@JogoGenero,@JogoFaixa,@JogoPlataforma,@JogoData,@JogoSinopse)", con.ConectarBd());
            cmd.Parameters.Add("@JogoID", MySqlDbType.VarChar).Value = jog.JogoID;
            cmd.Parameters.Add("@JogoNome", MySqlDbType.VarChar).Value = jog.JogoNome;
            cmd.Parameters.Add("@JogoVersao", MySqlDbType.VarChar).Value = jog.JogoVersao;
            cmd.Parameters.Add("@JogoDev", MySqlDbType.VarChar).Value = jog.JogoDev;
            cmd.Parameters.Add("@JogoGenero", MySqlDbType.VarChar).Value = jog.JogoGenero;
            cmd.Parameters.Add("@JogoFaixa", MySqlDbType.VarChar).Value = jog.JogoFaixa;
            cmd.Parameters.Add("@JogoPlataforma", MySqlDbType.VarChar).Value = jog.JogoPlataforma;
            cmd.Parameters.Add("@JogoData", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@JogoSinopse", MySqlDbType.VarChar).Value = jog.JogoSinopse;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }
        public void DeletarJogo(int dlt)
        {
            var comando = String.Format("delete from Jogo where JogoID = {0}", dlt);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            cmd.ExecuteReader();
        }
        public Jogo ListarJogoID(int cod)
        {
            var comando = String.Format("select * from Jogo where JogoID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBd());
            var DadosJogo = cmd.ExecuteReader();
            return ListarJogoID(DadosJogo).FirstOrDefault();
        }
        public List<Jogo> ListarJogoID(MySqlDataReader dt)
        {
            var AltAl2 = new List<Jogo>();
            while (dt.Read())
            {
                var AlTemp2 = new Jogo()
                {
                    JogoID = dt["JogoID"].ToString(),
                    JogoNome = dt["JogoNome"].ToString(),
                    JogoVersao = dt["JogoVersao"].ToString(),
                    JogoDev = dt["JogoDev"].ToString(),
                    JogoGenero = dt["JogoGenero"].ToString(),
                    JogoPlataforma = dt["JogoPlataforma"].ToString(),
                    JogoData = DateTime.Parse(dt["ClienteDataNascimento"].ToString()),
                    JogoSinopse = dt["JogoPlataforma"].ToString()
                };
                AltAl2.Add(AlTemp2);

            }
            dt.Close();
            return AltAl2;

        }
        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from Jogo", con.ConectarBd());
            var DadosJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosJogo);
        }
        public List<Jogo> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosJogo = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    JogoID = dt["JogoID"].ToString(),
                    JogoNome = dt["JogoNome"].ToString(),
                    JogoVersao = dt["JogoVersao"].ToString(),
                    JogoDev = dt["JogoDev"].ToString(),
                    JogoGenero = dt["JogoGenero"].ToString(),
                    JogoPlataforma = dt["JogoPlataforma"].ToString(),
                    JogoData = DateTime.Parse(dt["ClienteDataNascimento"].ToString()),
                    JogoSinopse = dt["JogoPlataforma"].ToString()
                };
                TodosJogo.Add(JogoTemp);
            }
            dt.Close();
            return TodosJogo;
        }
    }
}