using System.Collections.Generic;

namespace Loja.Domain.Entidades
{
    public class Cliente
    {
        private int _codigo;
        private string _nome;
        private string _cpf;
        private string _email;
        private string _celular;
        private int _usuarioCodigo;
        private List<Endereco> _enderecos;
        private List<Cliente> _lista;

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

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Celular
        {
            get
            {
                return _celular;
            }

            set
            {
                _celular = value;
            }
        }

        public int UsuarioCodigo
        {
            get
            {
                return _usuarioCodigo;
            }

            set
            {
                _usuarioCodigo = value;
            }
        }


        public List<Endereco> Enderecos
        {
            get
            {
                return _enderecos;
            }

            set
            {
                _enderecos = value;
            }
        }

        public List<Cliente> Lista
        {
            get
            {
                return _lista;
            }

            set
            {
                _lista = value;
            }
        }

        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }
       

        public void Initializer()
        {
            _lista = new List<Cliente>
            {
                new Cliente {
                    Codigo = 1,
                    Nome = "André Dias Goulart",
                    Cpf = "123.456.789-00",
                    Email = "andredias@teste.com",
                    Celular = "(11) 96543-2111",
                    UsuarioCodigo = 1,
                    Enderecos = new List<Endereco>
                    {
                        new Endereco {Codigo = 1, Cep= "12345-123", Logradouro = "Rua Um", Numero = "1", Complemento = "", Bairro = "LongiVille", Cidade = "UmaCidadeQualquer1", Estado = "UmEstadoQualquer", Uf = "EQ", Pais = "Brasil", TipoEndereco = Enums.TipoEndereco.Residencial },
                        new Endereco {Codigo = 2, Cep= "12345-124", Logradouro = "Rua Dois", Numero = "2", Complemento = "", Bairro = "LongiVille", Cidade = "UmaCidadeQualquer1", Estado = "UmEstadoQualquer", Uf = "EQ", Pais = "Brasil", TipoEndereco = Enums.TipoEndereco.Entrega }
                    }
                },
                new Cliente
                {
                    Codigo = 2,
                    Nome = "Noemia Silva Santos",
                    Cpf = "009.876.543-21",
                    Email = "noemia_silva@teste.com",
                    Celular = "(11) 91234-2239",
                    UsuarioCodigo = 2,
                    Enderecos = new List<Endereco>
                    {
                        new Endereco {Codigo = 1, Cep= "04536-123", Logradouro = "Rua Um", Numero = "1", Complemento = "", Bairro = "Araçai", Cidade = "Fortaleza", Estado = "Ceará", Uf = "CE", Pais = "Brasil", TipoEndereco = Enums.TipoEndereco.Comercial },
                        new Endereco {Codigo = 2, Cep= "04536-124", Logradouro = "Rua Dois", Numero = "2", Complemento = "", Bairro = "Araçai", Cidade = "Fortaleza", Estado = "Ceará", Uf = "CE", Pais = "Brasil", TipoEndereco = Enums.TipoEndereco.Entrega }
                    }
                }
            };
        }
    }
}
