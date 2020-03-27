using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TelaLogin.Models;

namespace TelaLogin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Principal()
        {
            Login logado = new Login();
            return View(logado);

        }

        [HttpPost]
        public ActionResult ValidarLogin(FormCollection form)
        {
            Comandos com = new Comandos();

            com.verificarLogin(form["usuario"].ToString(), form["senha"].ToString());

            if(com.mensagem != "")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if(com.T)
                {
                    Login logado = new Login();
                    logado.setLogado(form["usuario"].ToString());

                    return RedirectToAction("Principal", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }
    }
}