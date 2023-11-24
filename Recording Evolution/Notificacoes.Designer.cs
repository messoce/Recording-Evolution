
namespace Recording_Evolution
{
    partial class Notificacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxNotificarRegistro = new System.Windows.Forms.CheckBox();
            this.checkBoxNotificarAtrasos = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificar antes do registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo antes do registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notificar atrasos:";
            // 
            // checkBoxNotificarRegistro
            // 
            this.checkBoxNotificarRegistro.AutoSize = true;
            this.checkBoxNotificarRegistro.Location = new System.Drawing.Point(232, 15);
            this.checkBoxNotificarRegistro.Name = "checkBoxNotificarRegistro";
            this.checkBoxNotificarRegistro.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNotificarRegistro.TabIndex = 3;
            this.checkBoxNotificarRegistro.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotificarAtrasos
            // 
            this.checkBoxNotificarAtrasos.AutoSize = true;
            this.checkBoxNotificarAtrasos.Location = new System.Drawing.Point(232, 71);
            this.checkBoxNotificarAtrasos.Name = "checkBoxNotificarAtrasos";
            this.checkBoxNotificarAtrasos.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNotificarAtrasos.TabIndex = 5;
            this.checkBoxNotificarAtrasos.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10 min.",
            "5min."});
            this.comboBox1.Location = new System.Drawing.Point(208, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Notificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 101);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxNotificarAtrasos);
            this.Controls.Add(this.checkBoxNotificarRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Notificacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxNotificarRegistro;
        private System.Windows.Forms.CheckBox checkBoxNotificarAtrasos;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}