using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Endereço
    {
        private int _id;
        private string _nome;
        private string _cep;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;

        public Endereço(int id,
            string nome,
          string cep,
          string rua,
          string numero,
          string bairro,
          string cidade,
          string estado)
        {
            Id = id;

            Nome = nome;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Nome
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO NOME ESTÁ VAZIO");
                _nome = value; }
            get { return _nome; }
        }
        public string Cep
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO CEP ESTÁ VAZIO");
                _cep = value; }
            get { return _cep; }
        }
        public string Rua
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO RUA ESTÁ VAZIO");
                _rua = value; }
            get { return _rua; }
        }
        public string Numero
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO NUMERO ESTÁ VAZIO");
                _numero = value; }
            get { return _numero; }
        }
        public string Bairro
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO BAIRRO ESTÁ VAZIO");
                _bairro = value; }
            get { return _bairro; }
        }
        public string Cidade
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO SENHA ESTÁ VAZIO");
                _cidade = value; }
            get { return _cidade; }
        }
        public string Estado
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("CAMPO ESTADO ESTÁ VAZIO");
                _estado = value; }
            get { return _estado; }
        }







    }
}

