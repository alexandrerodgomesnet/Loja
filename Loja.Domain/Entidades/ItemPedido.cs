namespace Loja.Domain.Entidades
{
    public class ItemPedido
    {
        private int _codigo;
        private decimal _precoCompra;
        private Produto _produto;

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
        public decimal PrecoCompra
        {
            get
            {
                return _precoCompra;
            }

            set
            {
                _precoCompra = value;
            }
        }
        public Produto Produto
        {
            get
            {
                return _produto;
            }

            set
            {
                _produto = value;
            }
        }
    }
}
