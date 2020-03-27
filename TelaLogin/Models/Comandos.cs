using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TelaLogin.Models
{
    public class Comandos
    {
        public bool T = false;
        public String mensagem = "";
        SqlCommand com = new SqlCommand();
        Conexao cn = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String usuario, String senha)
        {
            com.CommandText = "SELECT USUARIO, SENHA FROM LOGINS WHERE USUARIO=@usuario AND SENHA=@senha";
            com.Parameters.AddWithValue("@usuario", usuario);
            com.Parameters.AddWithValue("@senha", senha);

            try 
            {
                com.Connection = cn.Conectar();
                dr = com.ExecuteReader();

                if(dr.HasRows)
                {
                    T = true;
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }

            return T;
        }
    }
}