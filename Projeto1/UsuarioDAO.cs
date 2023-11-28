using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

            List<Usuario> usuarios = new List<Usuario>();

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

                    usuarios.Add(objeto);

                }
                dr.Close();

                return usuarios;//retornar a lista 
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

        public void UpdateCliente(Usuario usuario)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE emprestimo SET 
             NomedoLivro = @Livro,
             Autor    = @Autor,
             Tempo    = @Tempo, 
             Nome     = @Nome,
             CPF      = @CPF,
             telefone = @telefone
             WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@ncartao", usuario.Ncartao);
            sqlCommand.Parameters.AddWithValue("@cvc", usuario.Cvc);
            sqlCommand.Parameters.AddWithValue("@id",usuario.Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void InsertUsuario(Usuario usuario)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO emprestimo VALUES (@nome, @email, @cpf, @ncartao, @cvc, @senha)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@ncartao", usuario.Ncartao);
            sqlCommand.Parameters.AddWithValue("@cvc", usuario.Cvc);

            sqlCommand.ExecuteNonQuery();

        }
        public void DeleteUser(int id)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Usuarios WHERE id = @id";
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
    }
}



