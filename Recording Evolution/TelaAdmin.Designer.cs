
namespace Recording_Evolution
{
    partial class TelaAdmin
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
            this.components = new System.ComponentModel.Container();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selecionaData = new System.Windows.Forms.DateTimePicker();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 70);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(737, 345);
            this.dgvFuncionarios.TabIndex = 0;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            this.dgvFuncionarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellEndEdit);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(335, 12);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(136, 20);
            this.txtFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID do Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // selecionaData
            // 
            this.selecionaData.Location = new System.Drawing.Point(271, 38);
            this.selecionaData.Name = "selecionaData";
            this.selecionaData.Size = new System.Drawing.Size(200, 20);
            this.selecionaData.TabIndex = 4;
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(477, 35);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 5;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(Recording_Evolution.Funcionarios);
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 429);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.selecionaData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "TelaAdmin";
            this.Text = "TelaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker selecionaData;
        private System.Windows.Forms.Button botaoBuscar;
    }
}