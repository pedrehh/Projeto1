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

        public Form1( )
        {
            InitializeComponent();

           
        }

        public Form1(int v)
        {
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();           

            try
            {
                foreach(Usuario usuario in usuarios)
                {
                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.Nome);
                    lv.SubItems.Add(usuario.Email);
                    lv.SubItems.Add(usuario.Cpf);
                    lv.SubItems.Add(usuario.Ncartao);
                    lv.SubItems.Add(usuario.Cvc.ToString());
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
                Usuario usuario = new Usuario (mtbname.Text,
                                              mtbemail.Text,
                                              txbcpf.Text,
                                              mtxcard.Text,
                                              mtbcvc.Text,
                                              mtbsenha.Text  );

                UsuarioDAO clidados = new UsuarioDAO();
                clidados.InsertUsuario(usuario);

                MessageBox.Show("VOCÊ FOI CADASTRADO ",
              "METFLIX",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
          
            mtbname.Clear();
            mtbemail.Clear();
            txbcpf.Clear();
            mtxcard.Clear();
            mtbcvc.Clear();
            mtbsenha.Clear();

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
                Usuario usuario = new Usuario(mtbname.Text,
                                              mtbemail.Text,
                                              txbcpf.Text,
                                              mtxcard.Text,
                                              mtbcvc.Text,
                                              mtbsenha.Text);

                UsuarioDAO clidados = new UsuarioDAO();
                clidados.UpdateCliente(usuario);

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
            mtbemail.Clear();
            txbcpf.Clear();
            mtxcard.Clear();
            mtbcvc.Clear();
            mtbsenha.Clear();

            UpdateListView();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            mtbname.Text = listView1.Items[index].SubItems[1].Text;
            mtbemail.Text = listView1.Items[index].SubItems[2].Text;
            txbcpf.Text = listView1.Items[index].SubItems[3].Text;
            mtxcard.Text = listView1.Items[index].SubItems[4].Text;
            mtbcvc.Text = listView1.Items[index].SubItems[5].Text;
            mtbsenha.Text = listView1.Items[index].SubItems[6].Text;
        }
                                   
        private void button1_Click_1(object sender, EventArgs e)
        {
            UsuarioDAO nomeDoObj = new UsuarioDAO();
            nomeDoObj.DeleteUser(id);

            mtbname.Clear();
            mtbemail.Clear();
            txbcpf.Clear();
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
        }
    }

