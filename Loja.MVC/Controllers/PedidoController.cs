using Loja.Domain.Entidades;
using Loja.MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace Loja.MVC.Controllers
{
    public class PedidoController : ControllerUser
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirItem(int codigo)
        {
            var produto = new Produto();
            produto.Initializer();

            var prod = produto.Lista.FirstOrDefault(p => p.Codigo == codigo);

            if (prod.Codigo > 0)
            {
                var pedido = new Pedido(prod);
                pedido.AdicionarItemPedido();

                return Json(new { ValorTotal = pedido.ValorTotal });
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult RemoverItem(int codigo)
        {
            var produto = new Produto();
            produto.Initializer();

            var prod = produto.Lista.FirstOrDefault(p => p.Codigo == codigo);

            if (prod.Codigo > 0)
            {
                var pedido = new Pedido(prod);
                pedido.RemoverItemPedido();

                return Json(new { ValorTotal = pedido.ValorTotal });
            }

            return Json(null);
        }

        public ActionResult FecharPedido()
        {
            var pedido = new Pedido();
            pedido.FecharPedido();

            var view = new FecharPedidoViewModel
            {
                Pedido = pedido
            };

            return View(view);
        }
    }
}