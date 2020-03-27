using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TelaLogin.Models
{
    public class Conexao
    {
        string erro;

        SqlConnection cn = new SqlConnection(@"Data Source=localHost; Initial Catalog=LOGINTESTE ; Integrated Security=True");

        public SqlConnection Conectar()
        { 
            try
            {
                cn.Open();
            }
            catch(Exception e)
            {
                erro = e.Message;
            }

            return cn;
        }

        public SqlConnection Desconectar()
        {
            try 
            {
                cn.Close();
            }
            catch(Exception e)
            {
                erro = e.Message;
            }
            return cn;
        }
    }
}