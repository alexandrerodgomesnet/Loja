using Loja.Domain.Commom;
using System.Collections.Generic;

namespace Loja.Domain.Entidades
{
    public class Produto
    {
        private IEnumerable<Produto> _lista;
        private int _codigo;
        private string _nome;
        private string _foto;
        private string _descricao;
        private decimal _preco;
        private CheckBox _checkbox;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public IEnumerable<Produto> Lista
        {
            get { return _lista; }
            set { _lista = value; }
        }

        public CheckBox Checkbox
        {
            get
            {
                return _checkbox;
            }

            set
            {
                _checkbox = value;
            }
        }

        public void Initializer()
        {
            _lista = new List<Produto>
            {
                new Produto { Codigo = 1, Nome = "Camisa Masculina", Foto = "camisa_masculina.jpg", Descricao = "Camisa Masculina Jeans", Preco = 119.99M },
                new Produto { Codigo = 2, Nome = "Blusa feminina alças", Foto = "blusa_feminina.jpg", Descricao = "Blusa feminina alças finas estampa floral", Preco = 69.99M },
                new Produto { Codigo = 3, Nome = "Casaco Infantil", Foto = "casaco_infantil.jpg", Descricao = "Casaco Infantil Moletom Bordado", Preco = 49.99M }
            };
        }
    }
}
