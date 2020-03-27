using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelaLogin.Models
{
    public class Login
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        static String logado;

        public void setLogado(string nome)
        {
            logado = nome;
        }

        public string getLogado()
        {
            return logado;
        }
    }
}