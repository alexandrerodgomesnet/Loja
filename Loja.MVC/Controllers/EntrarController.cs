using Loja.Domain.Entidades;
using Loja.MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace Loja.MVC.Controllers
{
    public class EntrarController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(login);

            var usuario = new Usuario();
            usuario.Initializer();

            var user = usuario.Lista.FirstOrDefault(u => u.Login == login.Usuario && u.Senha == login.Senha);

            if (user.Codigo > 0)
            {
                var cliente = new Cliente();
                cliente.Initializer();

                var cli = cliente.Lista.FirstOrDefault(c => c.UsuarioCodigo == user.Codigo);

                Session["User"] = cli;
                return RedirectToAction("Index", "Home");
            }
            else
                ModelState.AddModelError("", "Login inválido!");

            return View(login);
        }

        public ActionResult LogOff()
        {
            Session["User"] = null;
            Session["ItemPedido"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}