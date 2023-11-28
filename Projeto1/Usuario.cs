using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _cpf;
        private string _ncartao;
        private string _cvc;
        private string _senha;
    
        public Usuario(int id,
            string nome,
          string emai,
          string cpf,
          string ncartao,
          string cvc,
          string senha)
        {
            Id = id;
            
            Nome = nome;
            Email = emai;
            Cpf = cpf;
            Ncartao = ncartao;
            Cvc = cvc;
            Senha = senha;
        }

        public Usuario(
            string nome,
          string emai,
          string cpf,
          string ncartao,
          string cvc,
          string senha)
        {

            Nome = nome;
            Email = emai;
            Cpf = cpf;
            Ncartao = ncartao;
            Cvc = cvc;
            Senha = senha;
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
            public string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
             public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
             public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
            public string Ncartao
        {
            set { _ncartao = value; }
            get { return _ncartao; }
        }
            public string Cvc
        {
            set { _cvc = value; }
            get { return _cvc; }
        }
            public string Senha
        {
            set { _senha = value; }
            get { return _senha; }
        }



        



    }
}

