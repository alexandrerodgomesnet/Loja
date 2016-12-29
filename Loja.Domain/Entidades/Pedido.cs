using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Domain.Entidades
{
    public class Pedido
    {
        private int _codigo;
        private Cliente _cliente;
        private List<ItemPedido> _listaItens;
        private Produto _produto;

        public decimal ValorTotal
        {
            get
            {
                return ListaItens.Sum(x => x.PrecoCompra);
            }
        }
        public Pedido()
        {
            _listaItens = new List<ItemPedido>();
        }

        public Pedido(Produto produto) : this()
        {
            _produto = produto;
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }

            set
            {
                _cliente = value;
            }
        }

        public List<ItemPedido> ListaItens
        {
            get
            {
                return _listaItens;
            }

            set
            {
                _listaItens = value;
            }
        }

        public void AdicionarItemPedido()
        {
            _listaItens.Add(new ItemPedido
            {
                Codigo = _listaItens.Count > 0 ? _listaItens.Max(t => t.Codigo) + 1 : 1,
                Produto = _produto,
                PrecoCompra = _produto.Preco
            });

            if (HttpContext.Current.Session["ItemPedido"] == null)
                HttpContext.Current.Session["ItemPedido"] = _listaItens;
            else
                ((List<ItemPedido>)HttpContext.Current.Session["ItemPedido"]).AddRange(_listaItens);

            _listaItens = ((List<ItemPedido>)HttpContext.Current.Session["ItemPedido"]);
        }

        public void FecharPedido()
        {
            _listaItens = (List<ItemPedido>)HttpContext.Current.Session["ItemPedido"];
            _cliente = (Cliente)HttpContext.Current.Session["User"];
        }

        public void RemoverItemPedido()
        {
            _listaItens = ((List<ItemPedido>)HttpContext.Current.Session["ItemPedido"]);

            var item = _listaItens.FirstOrDefault(i => i.Produto.Codigo == _produto.Codigo);

            _listaItens.Remove(item);
        }
    }
}
