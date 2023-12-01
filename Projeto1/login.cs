using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            //criptografa a senha digitada no login
            string senhalogin = Criptografar(mtbsenha.Text);

            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            //resgata a senha do banco de dados com base no cpf do usuário
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM METFLIX WHERE nome = @nome";
            sqlCommand.Parameters.AddWithValue("@nome", mtbnome.Text);

            //verifica se o campo nao está vazio
            if (string.IsNullOrEmpty(mtbnome.Text))
            {
                MessageBox.Show(
                    "INSIRA SEU NOME",
                    "ATENÇÂO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                mtbnome.Clear();
            }
            if (string.IsNullOrEmpty(mtbsenha.Text))
            {
                MessageBox.Show(
                    "INSIRA SUA SENHA",
                    "ATENÇÂO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                mtbsenha.Clear();
            }

            //faz a leitura e o armazenamento da senha do banco de dados
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string senhasalva = (string)reader["senha"];

                    //verifica se a senha do login e a senha do banco de dados é a mesma (ambas estão criptografadas)
                    if (senhalogin == senhasalva)
                    {
                        MessageBox.Show(
                            "LOGIN REALIZADO COM SUCESSO",
                            "ATENÇÂO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Form3 form3 = new Form3();
                        form3.ShowDialog();

                        mtbnome.Clear();
                        mtbsenha.Clear();
                    }
                    else
                    {
                        MessageBox.Show(
                            "OS DADOS ESTÃO ERRADOS ",
                            "ATENÇÂO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string Criptografar(string input)
        {
            // Calcula o hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
