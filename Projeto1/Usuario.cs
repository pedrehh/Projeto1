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
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
            public string Nome
        {
            set {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO NOME ESTÁ VAZIO"); 
                _nome = value; }
            get { return _nome; }
        }
             public string Email
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO EMAIL ESTÁ VAZIO");
                _email = value; }
            get { return _email; }
        }
             public string Cpf
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO CPF ESTÁ VAZIO"); 
                _cpf = value; }
            get { return _cpf; }
        }
            public string Ncartao
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO NUMERO DO CARTÃO ESTÁ VAZIO");
                _ncartao = value; }
            get { return _ncartao; }
        }
            public string Cvc
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO CVV ESTÁ VAZIO");
                _cvc = value; }
            get { return _cvc; }
        }
            public string Senha
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO SENHA ESTÁ VAZIO");
                _senha = value; }
            get { return _senha; }
        }



        



    }
}

