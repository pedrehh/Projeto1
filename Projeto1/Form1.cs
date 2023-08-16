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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
                string name = txbname.Text;
                string enrollment = txbpront.Text;
            string message = "Nome:" + name +

                             "\nMatrícula: " + enrollment;
            MessageBox.Show(
                message,
                "ATENÇAO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error

                 );
        }
    }
}
