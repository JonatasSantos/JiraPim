namespace JiraPim
{
    partial class frmSolicitante
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
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.btnPesquisarChamado = new System.Windows.Forms.Button();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResumo = new System.Windows.Forms.Label();
            this.lblStatusChamado = new System.Windows.Forms.Label();
            this.lblChamadoID = new System.Windows.Forms.Label();
            this.lblNumChamado = new System.Windows.Forms.Label();
            this.gbxAreaSolicitante = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtChamadoID = new System.Windows.Forms.TextBox();
            this.cbxStatusChamado = new System.Windows.Forms.ComboBox();
            this.mskDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.mskDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.gbxAreaSolicitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Location = new System.Drawing.Point(21, 33);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(90, 24);
            this.btnNovoChamado.TabIndex = 0;
            this.btnNovoChamado.Text = "Novo Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarChamado
            // 
            this.btnPesquisarChamado.Location = new System.Drawing.Point(627, 91);
            this.btnPesquisarChamado.Name = "btnPesquisarChamado";
            this.btnPesquisarChamado.Size = new System.Drawing.Size(107, 27);
            this.btnPesquisarChamado.TabIndex = 1;
            this.btnPesquisarChamado.Text = "Pesquisar";
            this.btnPesquisarChamado.UseVisualStyleBackColor = true;
            this.btnPesquisarChamado.Click += new System.EventHandler(this.btnPesquisarChamado_Click);
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(330, 80);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(71, 15);
            this.lblDataInicial.TabIndex = 2;
            this.lblDataInicial.Text = "Data inicial:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(463, 80);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(62, 15);
            this.lblDataFinal.TabIndex = 3;
            this.lblDataFinal.Text = "Data final:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(463, 155);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(233, 155);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(54, 15);
            this.lblResumo.TabIndex = 5;
            this.lblResumo.Text = "Resumo";
            // 
            // lblStatusChamado
            // 
            this.lblStatusChamado.AutoSize = true;
            this.lblStatusChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusChamado.Location = new System.Drawing.Point(190, 80);
            this.lblStatusChamado.Name = "lblStatusChamado";
            this.lblStatusChamado.Size = new System.Drawing.Size(44, 15);
            this.lblStatusChamado.TabIndex = 6;
            this.lblStatusChamado.Text = "Status:";
            // 
            // lblChamadoID
            // 
            this.lblChamadoID.AutoSize = true;
            this.lblChamadoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamadoID.Location = new System.Drawing.Point(58, 80);
            this.lblChamadoID.Name = "lblChamadoID";
            this.lblChamadoID.Size = new System.Drawing.Size(97, 15);
            this.lblChamadoID.TabIndex = 7;
            this.lblChamadoID.Text = "Nº do Chamado:";
            // 
            // lblNumChamado
            // 
            this.lblNumChamado.AutoSize = true;
            this.lblNumChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumChamado.Location = new System.Drawing.Point(58, 155);
            this.lblNumChamado.Name = "lblNumChamado";
            this.lblNumChamado.Size = new System.Drawing.Size(20, 15);
            this.lblNumChamado.TabIndex = 8;
            this.lblNumChamado.Text = "Nº";
            // 
            // gbxAreaSolicitante
            // 
            this.gbxAreaSolicitante.Controls.Add(this.mskDataFinal);
            this.gbxAreaSolicitante.Controls.Add(this.mskDataInicial);
            this.gbxAreaSolicitante.Controls.Add(this.cbxStatusChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblNumChamado);
            this.gbxAreaSolicitante.Controls.Add(this.txtChamadoID);
            this.gbxAreaSolicitante.Controls.Add(this.dataGridView1);
            this.gbxAreaSolicitante.Controls.Add(this.btnNovoChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblResumo);
            this.gbxAreaSolicitante.Controls.Add(this.lblStatusChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblStatus);
            this.gbxAreaSolicitante.Controls.Add(this.lblChamadoID);
            this.gbxAreaSolicitante.Controls.Add(this.lblDataFinal);
            this.gbxAreaSolicitante.Controls.Add(this.btnPesquisarChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblDataInicial);
            this.gbxAreaSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAreaSolicitante.Location = new System.Drawing.Point(12, 27);
            this.gbxAreaSolicitante.Name = "gbxAreaSolicitante";
            this.gbxAreaSolicitante.Size = new System.Drawing.Size(811, 427);
            this.gbxAreaSolicitante.TabIndex = 9;
            this.gbxAreaSolicitante.TabStop = false;
            this.gbxAreaSolicitante.Text = "Área do Solicitante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 227);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtChamadoID
            // 
            this.txtChamadoID.Location = new System.Drawing.Point(61, 98);
            this.txtChamadoID.Name = "txtChamadoID";
            this.txtChamadoID.Size = new System.Drawing.Size(104, 20);
            this.txtChamadoID.TabIndex = 9;
            // 
            // cbxStatusChamado
            // 
            this.cbxStatusChamado.FormattingEnabled = true;
            this.cbxStatusChamado.Location = new System.Drawing.Point(193, 98);
            this.cbxStatusChamado.Name = "cbxStatusChamado";
            this.cbxStatusChamado.Size = new System.Drawing.Size(121, 21);
            this.cbxStatusChamado.TabIndex = 12;
            // 
            // mskDataInicial
            // 
            this.mskDataInicial.Location = new System.Drawing.Point(333, 98);
            this.mskDataInicial.Mask = "00/00/0000";
            this.mskDataInicial.Name = "mskDataInicial";
            this.mskDataInicial.Size = new System.Drawing.Size(100, 20);
            this.mskDataInicial.TabIndex = 13;
            this.mskDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataFinal
            // 
            this.mskDataFinal.Location = new System.Drawing.Point(466, 99);
            this.mskDataFinal.Mask = "00/00/0000";
            this.mskDataFinal.Name = "mskDataFinal";
            this.mskDataFinal.Size = new System.Drawing.Size(100, 20);
            this.mskDataFinal.TabIndex = 14;
            this.mskDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // frmSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 466);
            this.Controls.Add(this.gbxAreaSolicitante);
            this.Name = "frmSolicitante";
            this.Text = "frmSolicitante";
            this.gbxAreaSolicitante.ResumeLayout(false);
            this.gbxAreaSolicitante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Button btnPesquisarChamado;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblStatusChamado;
        private System.Windows.Forms.Label lblChamadoID;
        private System.Windows.Forms.Label lblNumChamado;
        private System.Windows.Forms.GroupBox gbxAreaSolicitante;
        private System.Windows.Forms.ComboBox cbxStatusChamado;
        private System.Windows.Forms.TextBox txtChamadoID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskDataFinal;
        private System.Windows.Forms.MaskedTextBox mskDataInicial;
    }
}