using Loja.Domain.Commom;

namespace Loja.MVC.Models
{
    public class ProdutoViewModel
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }
        public string Descricao { get; set; }

        public decimal Preco { get; set; }
        public CheckBox CheckBox { get; set; }
    }
}