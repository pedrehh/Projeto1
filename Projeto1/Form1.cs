using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        private int id;

        public Form1()
        {
            InitializeComponent();
            UpdateListView();
        }

        public Form1(int v)
        {
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO UsuarioDAO = new UsuarioDAO();
            List<Usuario> Usuarios = UsuarioDAO.SelectUsuario();

            try
            {
                foreach (Usuario Usuario in Usuarios)
                {
                    ListViewItem lv = new ListViewItem(Usuario.Id.ToString());
                    lv.SubItems.Add(Usuario.Nome);
                    lv.SubItems.Add(Usuario.Email);
                    lv.SubItems.Add(Usuario.Cpf);
                    lv.SubItems.Add(Usuario.Ncartao);
                    lv.SubItems.Add(Usuario.Cvc.ToString());
                    listView1.Items.Add(lv);

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            try
            {
                //realiza a definição do vetor que irá armazenar o cpf e a criação das variaveis que irão funcionar na validaçãp
                int[] validarcpf = new int[11];
                int validação1 = 0, validação2 = 0;
                int numero1 = 0, numero2 = 0;
                decimal numerocpf = Convert.ToDecimal(mtbcpf.Text.Replace(".", "").Replace("-", ""));

                for (; ; )
                {
                    if (numerocpf < 10000000000 || numerocpf > 99999999999)
                    {
                        MessageBox.Show(
                        "O CPF É INVÁLIDO",
                        "ATENÇÃO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        mtbcpf.Clear();
                        break;
                    }

                    else
                    {
                        for (int i = 10; i >= 0; i--)
                        {
                            validarcpf[i] = (int)(numerocpf % 10);
                            numerocpf /= 10;
                        }
                    }
                    //realiza a conta de multiplicação para a validação do digito 1
                    numero1 = (((((((((validarcpf[0] * 10) + validarcpf[1] * 9) + validarcpf[2] * 8) + validarcpf[3] * 7) + validarcpf[4] * 6) + validarcpf[5] * 5) + validarcpf[6] * 4) + validarcpf[7] * 3) + validarcpf[8] * 2) * 10;

                    //verifica se a validação deu certo
                    if (numero1 % 11 == validarcpf[9])
                    {
                        validação1 = 1;
                    }

                    //realiza a conta de multiplicação para a validação do digito 2
                    numero2 = ((((((((((validarcpf[0] * 11) + validarcpf[1] * 10) + validarcpf[2] * 9) + validarcpf[3] * 8) + validarcpf[4] * 7) + validarcpf[5] * 6) + validarcpf[6] * 5) + validarcpf[7] * 4) + validarcpf[8] * 3) + validarcpf[9] * 2) * 10;

                    //verifica se a validação deu certo
                    if (numero2 % 11 == validarcpf[10])
                    {
                        validação2 = 1;
                    }

                    //verifica se ambos os digitos são validos. se sim, executa a inserção do usuário
                    if (validação1 == 1 && validação2 == 1)
                    {
                        Usuario Usuario = new Usuario(id, mtbname.Text,
                                          mtbemail.Text,
                                          mtbcpf.Text,
                                          mtxcard.Text,
                                          mtbcvc.Text,
                                          mtbsenha.Text);

                        UsuarioDAO clidados = new UsuarioDAO();
                        clidados.InsertUsuario(Usuario);

                        MessageBox.Show("VOCÊ FOI CADASTRADO ",
                      "METFLIX",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

                        mtbname.Clear();
                        mtbemail.Clear();
                        mtbcpf.Clear();
                        mtxcard.Clear();
                        mtbcvc.Clear();
                        mtbsenha.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show(
                        "O CPF É INVÁLIDO",
                        "ATENÇÃO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        mtbcpf.Clear();
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            UpdateListView();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void lblpassword1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //realiza a definição do vetor que irá armazenar o cpf e a criação das variaveis que irão funcionar na validaçãp
                int[] validarcpf = new int[11];
                int validação1 = 0, validação2 = 0;
                int numero1 = 0, numero2 = 0;
                decimal numerocpf = Convert.ToDecimal(mtbcpf.Text.Replace(".", "").Replace("-", ""));

                for (; ; )
                {
                    if (numerocpf < 10000000000 || numerocpf > 99999999999)
                    {
                        MessageBox.Show(
                        "O CPF É INVÁLIDO",
                        "ATENÇÃO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        mtbcpf.Clear();
                        break;
                    }

                    else
                    {
                        for (int i = 10; i >= 0; i--)
                        {
                            validarcpf[i] = (int)(numerocpf % 10);
                            numerocpf /= 10;
                        }
                    }
                    //realiza a conta de multiplicação para a validação do digito 1
                    numero1 = (((((((((validarcpf[0] * 10) + validarcpf[1] * 9) + validarcpf[2] * 8) + validarcpf[3] * 7) + validarcpf[4] * 6) + validarcpf[5] * 5) + validarcpf[6] * 4) + validarcpf[7] * 3) + validarcpf[8] * 2) * 10;

                    //verifica se a validação deu certo
                    if (numero1 % 11 == validarcpf[9])
                    {
                        validação1 = 1;
                    }

                    //realiza a conta de multiplicação para a validação do digito 2
                    numero2 = ((((((((((validarcpf[0] * 11) + validarcpf[1] * 10) + validarcpf[2] * 9) + validarcpf[3] * 8) + validarcpf[4] * 7) + validarcpf[5] * 6) + validarcpf[6] * 5) + validarcpf[7] * 4) + validarcpf[8] * 3) + validarcpf[9] * 2) * 10;

                    //verifica se a validação deu certo
                    if (numero2 % 11 == validarcpf[10])
                    {
                        validação2 = 1;
                    }

                    //verifica se ambos os digitos são validos. se sim, executa a inserção do usuário
                    if (validação1 == 1 && validação2 == 1)
                    {
                        Usuario Usuario = new Usuario(id, mtbname.Text,
                                          mtbemail.Text,
                                          mtbcpf.Text,
                                          mtxcard.Text,
                                          mtbcvc.Text,
                                          mtbsenha.Text);

                        UsuarioDAO clidados = new UsuarioDAO();
                        clidados.UpdateCliente(Usuario);

                        MessageBox.Show("CADASTRO EDITADO ",
                      "METFLIX",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

                        mtbname.Clear();
                        mtbemail.Clear();
                        mtbcpf.Clear();
                        mtxcard.Clear();
                        mtbcvc.Clear();
                        mtbsenha.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show(
                        "O CPF É INVÁLIDO",
                        "ATENÇÃO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        mtbcpf.Clear();
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            UpdateListView();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            mtbname.Text = listView1.Items[index].SubItems[1].Text;
            mtbemail.Text = listView1.Items[index].SubItems[2].Text;
            mtbcpf.Text = listView1.Items[index].SubItems[3].Text;
            mtxcard.Text = listView1.Items[index].SubItems[4].Text;
            mtbcvc.Text = listView1.Items[index].SubItems[5].Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UsuarioDAO nomeDoObj = new UsuarioDAO();
            nomeDoObj.DeleteUser(id);

            mtbname.Clear();
            mtbemail.Clear();
            mtbcpf.Clear();
            mtxcard.Clear();
            mtbcvc.Clear();
            mtbsenha.Clear();
            UpdateListView();

            UpdateListView();

            MessageBox.Show("DELETADO COM SUCESSO",
                "METFLIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

