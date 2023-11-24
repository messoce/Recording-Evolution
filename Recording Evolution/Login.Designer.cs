
namespace Recording_Evolution
{
    partial class Login
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
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.BackColor = System.Drawing.Color.White;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrar.Location = new System.Drawing.Point(259, 386);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(78, 26);
            this.botaoEntrar.TabIndex = 0;
            this.botaoEntrar.Text = "Entrar";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCPF.Location = new System.Drawing.Point(12, 221);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(325, 20);
            this.txtBoxCPF.TabIndex = 1;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSenha.Location = new System.Drawing.Point(12, 293);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(325, 20);
            this.txtBoxSenha.TabIndex = 2;
            // 
            // txtCPF
            // 
            this.txtCPF.AutoSize = true;
            this.txtCPF.Location = new System.Drawing.Point(9, 205);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(59, 13);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.Text = "CPF / R.E.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recording_Evolution.Properties.Resources.Recording_Evolution_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(21, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxCPF);
            this.Controls.Add(this.botaoEntrar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

