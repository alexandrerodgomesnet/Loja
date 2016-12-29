using Loja.Domain.Enums;

namespace Loja.Domain.Entidades
{
    public class Endereco
    {
        private int _codigo;
        private string _cep;
        private string _logradouro;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _uf;
        private string _pais;
        private TipoEndereco _tipoEndereco;

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

        public string Cep
        {
            get
            {
                return _cep;
            }

            set
            {
                _cep = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return _logradouro;
            }

            set
            {
                _logradouro = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return _complemento;
            }

            set
            {
                _complemento = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }

            set
            {
                _bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                _cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public string Uf
        {
            get
            {
                return _uf;
            }

            set
            {
                _uf = value;
            }
        }

        public string Pais
        {
            get
            {
                return _pais;
            }

            set
            {
                _pais = value;
            }
        }

        public TipoEndereco TipoEndereco
        {
            get
            {
                return _tipoEndereco;
            }

            set
            {
                _tipoEndereco = value;
            }
        }

    }
}
