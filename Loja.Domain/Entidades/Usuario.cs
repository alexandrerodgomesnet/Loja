using System.Collections.Generic;

namespace Loja.Domain.Entidades
{
    public class Usuario
    {
        private int _codigo;
        private string _login;
        private string _senha;
        private List<Usuario> _lista;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public List<Usuario> Lista
        {
            get { return _lista; }
            set { _lista = value; }
        }

        public void Initializer()
        {
            _lista = new List<Usuario>
            {
                new Usuario { Codigo = 1, Login = "admin", Senha = "admin"},
                new Usuario { Codigo = 2, Login = "admin", Senha = "123"}
            };
        }
    }
}
