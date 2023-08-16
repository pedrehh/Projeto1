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
            this.txbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbpront = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.Color.Red;
            this.btnmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.ForeColor = System.Drawing.Color.White;
            this.btnmessage.Location = new System.Drawing.Point(397, 41);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(179, 159);
            this.btnmessage.TabIndex = 0;
            this.btnmessage.Text = "Aperte meu BUTAO";
            this.btnmessage.UseVisualStyleBackColor = false;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(153, 58);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(39, 13);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "NOME";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(156, 74);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(100, 20);
            this.txbname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRONTUARIO";
            // 
            // txbpront
            // 
            this.txbpront.Location = new System.Drawing.Point(156, 133);
            this.txbpront.Name = "txbpront";
            this.txbpront.Size = new System.Drawing.Size(100, 20);
            this.txbpront.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 338);
            this.Controls.Add(this.txbpront);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btnmessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbpront;
    }
}

