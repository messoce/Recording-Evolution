
namespace Recording_Evolution
{
    partial class telaHistorico
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
            this.selecionaData = new System.Windows.Forms.DateTimePicker();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtEntradaAlmoco = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtSaidaAlmoco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selecionaData
            // 
            this.selecionaData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionaData.CustomFormat = "dd-MM-yyyy";
            this.selecionaData.Location = new System.Drawing.Point(41, 12);
            this.selecionaData.Name = "selecionaData";
            this.selecionaData.Size = new System.Drawing.Size(200, 20);
            this.selecionaData.TabIndex = 1;
            this.selecionaData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(141, 49);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtEntradaAlmoco
            // 
            this.txtEntradaAlmoco.Location = new System.Drawing.Point(141, 75);
            this.txtEntradaAlmoco.Name = "txtEntradaAlmoco";
            this.txtEntradaAlmoco.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaAlmoco.TabIndex = 3;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(141, 127);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(100, 20);
            this.txtSaida.TabIndex = 4;
            // 
            // txtSaidaAlmoco
            // 
            this.txtSaidaAlmoco.Location = new System.Drawing.Point(141, 101);
            this.txtSaidaAlmoco.Name = "txtSaidaAlmoco";
            this.txtSaidaAlmoco.Size = new System.Drawing.Size(100, 20);
            this.txtSaidaAlmoco.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrada Almoço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saída";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saída Almoço";
            // 
            // telaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaidaAlmoco);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntradaAlmoco);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.selecionaData);
            this.Name = "telaHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker selecionaData;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtEntradaAlmoco;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtSaidaAlmoco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}