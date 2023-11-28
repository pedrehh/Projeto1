using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string usuario = mtbname2.Text;
            string senha = maskedTextBox1.Text;


            if (true)
            {
                Form tela = new Form();
                tela.ShowDialog();
            }
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(2);
            form1.ShowDialog();
        }
    }
}
