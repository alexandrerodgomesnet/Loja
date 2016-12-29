using Loja.Domain.Commom;
using Loja.Domain.Entidades;
using Loja.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Loja.MVC.Controllers
{
    public class ProdutoController : ControllerUser
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Listar()
        {
            var produto = new Produto();
            produto.Initializer();

            var lista = new List<ProdutoViewModel>();
            int id = 0;
            produto.Lista.ToList().ForEach(p =>
            {
                id++;
                lista.Add(new ProdutoViewModel
                {
                    Codigo = p.Codigo,
                    Nome = p.Nome,
                    Preco = p.Preco,
                    Descricao = p.Descricao,
                    Foto = p.Foto,
                    CheckBox = new CheckBox { Id = id, Name = p.Nome, Value = p.Codigo.ToString() }
                });
            });

            return PartialView("_Listar", lista);
        }
    }
}