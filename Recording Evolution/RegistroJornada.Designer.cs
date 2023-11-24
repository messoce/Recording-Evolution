
namespace Recording_Evolution
{
    partial class RegistroJornada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoRegistro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProximoRegistro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUltimoRegistro = new System.Windows.Forms.Label();
            this.botaoObservacao = new System.Windows.Forms.Button();
            this.botaoMenu = new System.Windows.Forms.Button();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoNotificacoes = new System.Windows.Forms.Button();
            this.botaoAtestados = new System.Windows.Forms.Button();
            this.botaoHistorico = new System.Windows.Forms.Button();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoRegistro
            // 
            this.botaoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRegistro.Location = new System.Drawing.Point(112, 259);
            this.botaoRegistro.Name = "botaoRegistro";
            this.botaoRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botaoRegistro.Size = new System.Drawing.Size(243, 50);
            this.botaoRegistro.TabIndex = 0;
            this.botaoRegistro.Text = "Registrar Jornada";
            this.botaoRegistro.UseVisualStyleBackColor = true;
            this.botaoRegistro.Click += new System.EventHandler(this.botaoRegistro_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(466, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "º Último Registro:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProximoRegistro
            // 
            this.lblProximoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoRegistro.Location = new System.Drawing.Point(1, 444);
            this.lblProximoRegistro.Name = "lblProximoRegistro";
            this.lblProximoRegistro.Size = new System.Drawing.Size(465, 44);
            this.lblProximoRegistro.TabIndex = 4;
            this.lblProximoRegistro.Text = "--:--";
            this.lblProximoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "º Próximo Registro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUltimoRegistro
            // 
            this.lblUltimoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoRegistro.Location = new System.Drawing.Point(1, 358);
            this.lblUltimoRegistro.Name = "lblUltimoRegistro";
            this.lblUltimoRegistro.Size = new System.Drawing.Size(464, 44);
            this.lblUltimoRegistro.TabIndex = 2;
            this.lblUltimoRegistro.Text = "--:--";
            this.lblUltimoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoObservacao
            // 
            this.botaoObservacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoObservacao.Location = new System.Drawing.Point(184, 509);
            this.botaoObservacao.Name = "botaoObservacao";
            this.botaoObservacao.Size = new System.Drawing.Size(99, 49);
            this.botaoObservacao.TabIndex = 5;
            this.botaoObservacao.Text = "+ Observ.";
            this.botaoObservacao.UseVisualStyleBackColor = true;
            this.botaoObservacao.Click += new System.EventHandler(this.botaoObservacao_Click);
            // 
            // botaoMenu
            // 
            this.botaoMenu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenu.Location = new System.Drawing.Point(12, 12);
            this.botaoMenu.Name = "botaoMenu";
            this.botaoMenu.Size = new System.Drawing.Size(34, 33);
            this.botaoMenu.TabIndex = 6;
            this.botaoMenu.Text = " ☰";
            this.botaoMenu.UseVisualStyleBackColor = true;
            this.botaoMenu.Click += new System.EventHandler(this.abreMenu);
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.LightGray;
            this.painelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelMenu.Controls.Add(this.botaoSair);
            this.painelMenu.Controls.Add(this.botaoNotificacoes);
            this.painelMenu.Controls.Add(this.botaoAtestados);
            this.painelMenu.Controls.Add(this.botaoHistorico);
            this.painelMenu.Location = new System.Drawing.Point(12, 12);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(240, 369);
            this.painelMenu.TabIndex = 7;
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.Transparent;
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSair.Location = new System.Drawing.Point(14, 312);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(214, 38);
            this.botaoSair.TabIndex = 11;
            this.botaoSair.Text = "Sair da Sessão";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.LogOff);
            // 
            // botaoNotificacoes
            // 
            this.botaoNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNotificacoes.Location = new System.Drawing.Point(14, 172);
            this.botaoNotificacoes.Name = "botaoNotificacoes";
            this.botaoNotificacoes.Size = new System.Drawing.Size(214, 38);
            this.botaoNotificacoes.TabIndex = 10;
            this.botaoNotificacoes.Text = "Notificações";
            this.botaoNotificacoes.UseVisualStyleBackColor = true;
            this.botaoNotificacoes.Click += new System.EventHandler(this.botaoNotificacoes_Click);
            // 
            // botaoAtestados
            // 
            this.botaoAtestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAtestados.Location = new System.Drawing.Point(14, 110);
            this.botaoAtestados.Name = "botaoAtestados";
            this.botaoAtestados.Size = new System.Drawing.Size(214, 38);
            this.botaoAtestados.TabIndex = 9;
            this.botaoAtestados.Text = "Atestados";
            this.botaoAtestados.UseVisualStyleBackColor = true;
            this.botaoAtestados.Click += new System.EventHandler(this.botaoAtestados_Click);
            // 
            // botaoHistorico
            // 
            this.botaoHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoHistorico.Location = new System.Drawing.Point(14, 48);
            this.botaoHistorico.Name = "botaoHistorico";
            this.botaoHistorico.Size = new System.Drawing.Size(214, 38);
            this.botaoHistorico.TabIndex = 8;
            this.botaoHistorico.Text = "Histórico";
            this.botaoHistorico.UseVisualStyleBackColor = true;
            this.botaoHistorico.Click += new System.EventHandler(this.abreHistorico);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(0, 226);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(469, 23);
            this.lblNomeFuncionario.TabIndex = 8;
            this.lblNomeFuncionario.Text = "Nome";
            this.lblNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recording_Evolution.Properties.Resources.icone_usuario;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 573);
            this.Controls.Add(this.botaoMenu);
            this.Controls.Add(this.painelMenu);
            this.Controls.Add(this.botaoObservacao);
            this.Controls.Add(this.lblProximoRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUltimoRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botaoRegistro);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistroJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Jornada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroJornada_FormClosed);
            this.Load += new System.EventHandler(this.RegistroJornada_Load);
            this.painelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProximoRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUltimoRegistro;
        private System.Windows.Forms.Button botaoObservacao;
        private System.Windows.Forms.Button botaoMenu;
        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Button botaoHistorico;
        private System.Windows.Forms.Button botaoNotificacoes;
        private System.Windows.Forms.Button botaoAtestados;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}