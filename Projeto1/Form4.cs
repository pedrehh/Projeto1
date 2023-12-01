using forms1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto1
{
    public partial class Form4 : Form
    {
        private int id;
        public Form4()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            EndereçoDAO EndereçoDAO = new EndereçoDAO();
            List<Endereço> endereços = EndereçoDAO.SelectEndereço();

            try
            {
                foreach (Endereço endereço in endereços)
                {
                    ListViewItem lv = new ListViewItem(endereço.Id.ToString());
                    lv.SubItems.Add(endereço.Nome);
                    lv.SubItems.Add(endereço.Cep);
                    lv.SubItems.Add(endereço.Rua);
                    lv.SubItems.Add(endereço.Numero);
                    lv.SubItems.Add(endereço.Bairro);
                    lv.SubItems.Add(endereço.Cidade);
                    lv.SubItems.Add(endereço.Estado);
                    listView1.Items.Add(lv);

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            try
            {
                Endereço endereço = new Endereço(id,
                                              mtbname.Text,
                                              mtbcep.Text,
                                              mtbrua.Text,
                                              mtbnumero.Text,
                                              mtbbairro.Text,
                                              mtbcidade.Text,
                                              mtbestado.Text);

                EndereçoDAO enddados = new EndereçoDAO();
                enddados.InsertEndereço(endereço);

                MessageBox.Show("ENDEREÇO CADASTRADO ",
                "METFLIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            mtbname.Clear();
            mtbcep.Clear();
            mtbrua.Clear();
            mtbnumero.Clear();
            mtbbairro.Clear();
            mtbcidade.Clear();
            mtbestado.Clear();

            UpdateListView();
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            mtbname.Text = listView1.Items[index].SubItems[1].Text;
            mtbcep.Text = listView1.Items[index].SubItems[2].Text;
            mtbrua.Text = listView1.Items[index].SubItems[3].Text;
            mtbnumero.Text = listView1.Items[index].SubItems[4].Text;
            mtbbairro.Text = listView1.Items[index].SubItems[5].Text;
            mtbcidade.Text = listView1.Items[index].SubItems[6].Text;
            mtbestado.Text = listView1.Items[index].SubItems[7].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndereçoDAO enddados = new EndereçoDAO();
            enddados.DeleteEndereço(id);

            mtbname.Clear();
            mtbcep.Clear();
            mtbrua.Clear();
            mtbnumero.Clear();
            mtbbairro.Clear();
            mtbcidade.Clear();
            mtbestado.Clear();

            UpdateListView();

            MessageBox.Show("DELETADO COM SUCESSO",
                "METFLIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            try
            {
                Endereço endereço = new Endereço(id,
                                                  mtbname.Text,
                                                  mtbcep.Text,
                                                  mtbrua.Text,
                                                  mtbnumero.Text,
                                                  mtbbairro.Text,
                                                  mtbcidade.Text,
                                                  mtbestado.Text);
                EndereçoDAO enddados = new EndereçoDAO();
                enddados.UpdateEndereço(id, endereço);

                MessageBox.Show("OS DADOS FORAM EDITADOS ",
                "METFLIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            mtbname.Clear();
            mtbcep.Clear();
            mtbrua.Clear();
            mtbnumero.Clear();
            mtbbairro.Clear();
            mtbcidade.Clear();
            mtbestado.Clear();

            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(mtbname.Text))
                {
                    MessageBox.Show(
                        "INSIRA SEU NOME ",
                        "ATENÇÂO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    mtbname.Clear();
                }
                //define os campos do relatório
                string nome, cep, numero, endereço, bairro, cidade, estado;

                //realiza a conexão e resgata os dados do banco de dados
                Conection connection = new Conection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM ENDEREÇO WHERE Nome = @nome";
                sqlCommand.Parameters.AddWithValue("@nome", mtbname.Text);

                //faz a leitura e o armazenamento desses dados
                using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                {
                    reader1.Read();

                    nome = (string)reader1["nome"];
                    cep = (string)reader1["cep"];
                    endereço = (string)reader1["rua"];
                    numero = (string)reader1["numero"];
                    bairro = (string)reader1["bairro"];
                    cidade = (string)reader1["cidade"];
                    estado = (string)reader1["estado"];
                }

                //define o caminho que o arquivo ficará salvo
                string Caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string NomeArquivo = "relatorio_" + mtbname.Text + ".pdf";
                string CaminhoCompleto = Path.Combine(Caminho, NomeArquivo);
                FileStream ArquivoPDF = new FileStream(CaminhoCompleto, FileMode.Create);
                Document Documento = new Document(PageSize.A4);
                PdfWriter pdfwriter = PdfWriter.GetInstance(Documento, ArquivoPDF);

                string dados = "";

                //define o texto e a formatação do primeiro paragrafo
                Paragraph Paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Bold));
                Paragrafo1.Alignment = Element.ALIGN_LEFT;
                Paragrafo1.Add("METFLIX");

                //define o texto e a formatação do segundo paragrafo
                Paragraph Paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Regular));
                Paragrafo2.Alignment = Element.ALIGN_LEFT;
                Paragrafo2.Add("Dados do Usuário:\n" + "Nome: " + nome + "\nCEP: " + cep + "\n Endereço: " + endereço + "\nNumero: " + numero + "\nBairro: " + bairro + "\nCidade: " + cidade + "\nEstado: " + estado);

                //cria o documento
                Documento.Open();
                Documento.Add(Paragrafo1);
                Documento.Add(Paragrafo2);
                Documento.Close();

                //exibe que deu tudo certo
                MessageBox.Show(
                "O RELATÓRIO FOI CRIADO ",
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao criar o relatório");
            }
        }
    }
}
    

