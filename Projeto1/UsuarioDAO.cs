using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    internal class UsuarioDAO
    {
 
        public List<Usuario> SelectUsuario()
        {
            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM METFLIX";

            List<Usuario> Usuarios = new List<Usuario>();

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(

                   (int)dr["Id"],
                   (string)dr["nome"],
                   (string)dr["email"],
                   (string)dr["cpf"],
                   (string)dr["ncartao"],
                   (string)dr["cvc"],
                   (string)dr["senha"]
                   );

                    Usuarios.Add(objeto);

                }
                dr.Close();

                return Usuarios;//retornar a lista 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }

        public void UpdateCliente(Usuario Usuario)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE METFLIX SET 
             nome = @nome,
             email = @email,
             cpf = @cpf, 
             ncartao = @ncartao,
             cvc = @cvc,
             senha = @senha
             WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", Usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", Usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", Usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@ncartao", Usuario.Ncartao);
            sqlCommand.Parameters.AddWithValue("@cvc", Usuario.Cvc);
            sqlCommand.Parameters.AddWithValue("@senha", Criptografar(Usuario.Senha));
            sqlCommand.Parameters.AddWithValue("@id",Usuario.Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void InsertUsuario(Usuario Usuario)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO METFLIX VALUES (@nome, @email, @cpf, @ncartao, @cvc, @senha)";

            sqlCommand.Parameters.AddWithValue("@nome", Usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", Usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", Usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@ncartao", Usuario.Ncartao);
            sqlCommand.Parameters.AddWithValue("@cvc", Usuario.Cvc);
            sqlCommand.Parameters.AddWithValue("@senha", Criptografar(Usuario.Senha));

            sqlCommand.ExecuteNonQuery();

        }
        public void DeleteUser(int id)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM METFLIX WHERE id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();

            }


        }
        public static string Criptografar(string input)
        {
            // Calcular o Hash
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



