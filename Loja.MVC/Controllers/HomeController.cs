using Loja.Domain.Entidades;
using System.Linq;
using System.Web.Mvc;

namespace Loja.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["ItemPedido"] = null;
            return View();
        }


        public PartialViewResult Listar()
        {
            var produto = new Produto();
            produto.Initializer();
            return PartialView("_ListarProduto", produto.Lista);
        }


        public ActionResult Detalhes(int id)
        {
            var produto = new Produto();
            produto.Initializer();

            return View(produto.Lista.FirstOrDefault(p => p.Codigo == id));
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Sobre da Loja.";

            return View();
        }
    }
}