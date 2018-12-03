namespace JiraPim
{
    partial class FrmInicio
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
            this.BtnFuncionarios = new System.Windows.Forms.Button();
            this.BtnChamados = new System.Windows.Forms.Button();
            this.BtnBoard = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Size = new System.Drawing.Size(104, 27);
            this.BtnFuncionarios.TabIndex = 0;
            this.BtnFuncionarios.Text = "Funcionarios";
            this.BtnFuncionarios.UseVisualStyleBackColor = true;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // BtnChamados
            // 
            this.BtnChamados.Location = new System.Drawing.Point(12, 45);
            this.BtnChamados.Name = "BtnChamados";
            this.BtnChamados.Size = new System.Drawing.Size(104, 27);
            this.BtnChamados.TabIndex = 1;
            this.BtnChamados.Text = "Chamados";
            this.BtnChamados.UseVisualStyleBackColor = true;
            this.BtnChamados.Click += new System.EventHandler(this.BtnChamados_Click);
            // 
            // BtnBoard
            // 
            this.BtnBoard.Location = new System.Drawing.Point(12, 78);
            this.BtnBoard.Name = "BtnBoard";
            this.BtnBoard.Size = new System.Drawing.Size(104, 27);
            this.BtnBoard.TabIndex = 2;
            this.BtnBoard.Text = "Board";
            this.BtnBoard.UseVisualStyleBackColor = true;
            this.BtnBoard.Click += new System.EventHandler(this.BtnBoard_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Red;
            this.BtnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSair.Location = new System.Drawing.Point(12, 111);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(104, 27);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 153);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnBoard);
            this.Controls.Add(this.BtnChamados);
            this.Controls.Add(this.BtnFuncionarios);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInicio_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFuncionarios;
        private System.Windows.Forms.Button BtnChamados;
        private System.Windows.Forms.Button BtnBoard;
        private System.Windows.Forms.Button BtnSair;
    }
}