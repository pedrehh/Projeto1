using Projeto1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace forms1
{
    internal class EndereçoDAO
    {
        public List<Endereço> SelectEndereço()
        {
            Conection conn = new Conection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM ENDEREÇO";

            List<Endereço> Endereços = new List<Endereço>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Endereço objeto = new Endereço(
                    (int)dr["id"],
                    (string)dr["nome"],
                    (string)dr["cep"],
                    (string)dr["rua"],
                    (string)dr["numero"],
                    (string)dr["bairro"],
                    (string)dr["cidade"],
                    (string)dr["estado"]
                    );
                    Endereços.Add(objeto);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return Endereços;
        }
        public void InsertEndereço(Endereço endereço)

        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO ENDEREÇO VALUES
            (@nome, @cep, @rua, @numero, @bairro, @cidade, @estado)";

            sqlCommand.Parameters.AddWithValue("@nome", endereço.Nome);
            sqlCommand.Parameters.AddWithValue("@cep", endereço.Cep);
            sqlCommand.Parameters.AddWithValue("@rua", endereço.Rua);
            sqlCommand.Parameters.AddWithValue("@numero", endereço.Numero);
            sqlCommand.Parameters.AddWithValue("@bairro", endereço.Bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", endereço.Cidade);
            sqlCommand.Parameters.AddWithValue("@estado", endereço.Estado);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateEndereço(int id, Endereço endereço)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE ENDEREÇO SET
            nome = @nome,
            cep = @cep,
            rua = @rua,
            numero = @numero, 
            bairro = @bairro,
            cidade = @cidade,
            estado = @estado
            WHERE id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", endereço.Nome);
            sqlCommand.Parameters.AddWithValue("@cep", endereço.Cep);
            sqlCommand.Parameters.AddWithValue("@rua", endereço.Rua);
            sqlCommand.Parameters.AddWithValue("@numero", endereço.Numero);
            sqlCommand.Parameters.AddWithValue("@bairro", endereço.Bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", endereço.Cidade);
            sqlCommand.Parameters.AddWithValue("@estado", endereço.Estado);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteEndereço(int id)
        {
            Conection connection = new Conection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM ENDEREÇO WHERE id = @id";
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


