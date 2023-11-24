
namespace Recording_Evolution
{
    partial class Observacoes
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
            this.textoObservacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoObservacoes
            // 
            this.textoObservacoes.Location = new System.Drawing.Point(15, 34);
            this.textoObservacoes.Multiline = true;
            this.textoObservacoes.Name = "textoObservacoes";
            this.textoObservacoes.Size = new System.Drawing.Size(332, 243);
            this.textoObservacoes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a hora e a observação:";
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(272, 289);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.botaoSalvar.TabIndex = 2;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // Observacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 324);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoObservacoes);
            this.Name = "Observacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observacao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Observacoes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoObservacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSalvar;
    }
}