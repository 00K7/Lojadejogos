using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lojadejogos.Repos
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost,DataBase=bdloja,user=root,pwd=hi135797");
        public static string msg;
        public MySqlConnection ConectarBd()
        {
            try
            {
                cn.Open();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um ero ao conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection DesconectarBd()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um ero ao desconectar" + erro.Message;
            }
            return cn;
        }
    }
}