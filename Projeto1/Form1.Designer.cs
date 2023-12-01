namespace Projeto1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmessage = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.mtxcard = new System.Windows.Forms.MaskedTextBox();
            this.lblcard = new System.Windows.Forms.Label();
            this.mtbcvc = new System.Windows.Forms.MaskedTextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblcvc = new System.Windows.Forms.Label();
            this.lblpassword1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbname = new System.Windows.Forms.MaskedTextBox();
            this.mtbemail = new System.Windows.Forms.MaskedTextBox();
            this.editar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mtbsenha = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.Color.Black;
            this.btnmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.ForeColor = System.Drawing.Color.Red;
            this.btnmessage.Location = new System.Drawing.Point(354, 320);
            this.btnmessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(587, 44);
            this.btnmessage.TabIndex = 0;
            this.btnmessage.Text = "CRIAR CONTA";
            this.btnmessage.UseVisualStyleBackColor = false;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Black;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(40, 34);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(153, 17);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "NOME DE USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-MAIL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(44, 193);
            this.mtbcpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(175, 22);
            this.mtbcpf.TabIndex = 11;
            this.mtbcpf.ValidatingType = typeof(int);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.White;
            this.lblcpf.Location = new System.Drawing.Point(40, 174);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 17);
            this.lblcpf.TabIndex = 10;
            this.lblcpf.Text = "CPF";
            // 
            // mtxcard
            // 
            this.mtxcard.Location = new System.Drawing.Point(44, 262);
            this.mtxcard.Margin = new System.Windows.Forms.Padding(4);
            this.mtxcard.Mask = "0000.0000.0000.0000";
            this.mtxcard.Name = "mtxcard";
            this.mtxcard.Size = new System.Drawing.Size(175, 22);
            this.mtxcard.TabIndex = 13;
            // 
            // lblcard
            // 
            this.lblcard.AutoSize = true;
            this.lblcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcard.ForeColor = System.Drawing.Color.White;
            this.lblcard.Location = new System.Drawing.Point(40, 242);
            this.lblcard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcard.Name = "lblcard";
            this.lblcard.Size = new System.Drawing.Size(93, 17);
            this.lblcard.TabIndex = 12;
            this.lblcard.Text = "Nº CARTÂO";
            // 
            // mtbcvc
            // 
            this.mtbcvc.Location = new System.Drawing.Point(44, 332);
            this.mtbcvc.Margin = new System.Windows.Forms.Padding(4);
            this.mtbcvc.Mask = "000";
            this.mtbcvc.Name = "mtbcvc";
            this.mtbcvc.Size = new System.Drawing.Size(175, 22);
            this.mtbcvc.TabIndex = 15;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(128, 313);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(0, 16);
            this.lblpassword.TabIndex = 14;
            // 
            // lblcvc
            // 
            this.lblcvc.AutoSize = true;
            this.lblcvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcvc.ForeColor = System.Drawing.Color.White;
            this.lblcvc.Location = new System.Drawing.Point(41, 311);
            this.lblcvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcvc.Name = "lblcvc";
            this.lblcvc.Size = new System.Drawing.Size(38, 17);
            this.lblcvc.TabIndex = 16;
            this.lblcvc.Text = "CVV";
            // 
            // lblpassword1
            // 
            this.lblpassword1.AutoSize = true;
            this.lblpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword1.ForeColor = System.Drawing.Color.White;
            this.lblpassword1.Location = new System.Drawing.Point(41, 388);
            this.lblpassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword1.Name = "lblpassword1";
            this.lblpassword1.Size = new System.Drawing.Size(60, 17);
            this.lblpassword1.TabIndex = 18;
            this.lblpassword1.Text = "SENHA";
            this.lblpassword1.Click += new System.EventHandler(this.lblpassword1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 135);
            this.label1.TabIndex = 19;
            this.label1.Text = "METFLIX";
            // 
            // mtbname
            // 
            this.mtbname.Location = new System.Drawing.Point(44, 63);
            this.mtbname.Margin = new System.Windows.Forms.Padding(4);
            this.mtbname.Name = "mtbname";
            this.mtbname.Size = new System.Drawing.Size(175, 22);
            this.mtbname.TabIndex = 20;
            // 
            // mtbemail
            // 
            this.mtbemail.Location = new System.Drawing.Point(44, 134);
            this.mtbemail.Margin = new System.Windows.Forms.Padding(4);
            this.mtbemail.Name = "mtbemail";
            this.mtbemail.Size = new System.Drawing.Size(175, 22);
            this.mtbemail.TabIndex = 21;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.Black;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.Red;
            this.editar.Location = new System.Drawing.Point(550, 507);
            this.editar.Margin = new System.Windows.Forms.Padding(4);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(175, 44);
            this.editar.TabIndex = 23;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(354, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome de Usuário";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPF";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nº Cartão";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CVC";
            this.columnHeader6.Width = 90;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(354, 372);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 127);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(743, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "ENDEREÇO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(44, 523);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 44);
            this.button3.TabIndex = 45;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtbsenha
            // 
            this.mtbsenha.Location = new System.Drawing.Point(43, 408);
            this.mtbsenha.Name = "mtbsenha";
            this.mtbsenha.PasswordChar = '*';
            this.mtbsenha.Size = new System.Drawing.Size(176, 22);
            this.mtbsenha.TabIndex = 46;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(43, 436);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(276, 20);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CONCORDO COM OS TERMOS DE USO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(44, 463);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(239, 20);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "GOSTARIA DE RECEBER EMAILS";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1112, 613);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.mtbsenha);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mtbemail);
            this.Controls.Add(this.mtbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpassword1);
            this.Controls.Add(this.lblcvc);
            this.Controls.Add(this.mtbcvc);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.mtxcard);
            this.Controls.Add(this.lblcard);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btnmessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.MaskedTextBox mtxcard;
        private System.Windows.Forms.Label lblcard;
        private System.Windows.Forms.MaskedTextBox mtbcvc;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcvc;
        private System.Windows.Forms.Label lblpassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbname;
        private System.Windows.Forms.MaskedTextBox mtbemail;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox mtbsenha;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

