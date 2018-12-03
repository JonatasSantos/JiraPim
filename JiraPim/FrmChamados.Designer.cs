namespace JiraPim
{
    partial class FrmChamados
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
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.btnPesquisarChamado = new System.Windows.Forms.Button();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblStatusChamado = new System.Windows.Forms.Label();
            this.lblChamadoID = new System.Windows.Forms.Label();
            this.gbxAreaSolicitante = new System.Windows.Forms.GroupBox();
            this.mskDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.cbxStatusChamado = new System.Windows.Forms.ComboBox();
            this.txtChamadoID = new System.Windows.Forms.TextBox();
            this.grdChamados = new System.Windows.Forms.DataGridView();
            this.cbxCriticidade = new System.Windows.Forms.ComboBox();
            this.lblCriticidade = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.db_JIRAPIM = new JiraPim.db_JIRAPIM();
            this.dbJIRAPIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUSCHAMADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUS_CHAMADOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.STATUS_CHAMADOTableAdapter();
            this.nIVELCHAMADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIVEL_CHAMADOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.NIVEL_CHAMADOTableAdapter();
            this.gbxAreaSolicitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSCHAMADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELCHAMADOBindingSource)).BeginInit();
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
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // btnPesquisarChamado
            // 
            this.btnPesquisarChamado.Location = new System.Drawing.Point(682, 94);
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
            this.lblDataInicial.Location = new System.Drawing.Point(300, 80);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(71, 15);
            this.lblDataInicial.TabIndex = 2;
            this.lblDataInicial.Text = "Data inicial:";
            // 
            // lblStatusChamado
            // 
            this.lblStatusChamado.AutoSize = true;
            this.lblStatusChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusChamado.Location = new System.Drawing.Point(160, 80);
            this.lblStatusChamado.Name = "lblStatusChamado";
            this.lblStatusChamado.Size = new System.Drawing.Size(44, 15);
            this.lblStatusChamado.TabIndex = 6;
            this.lblStatusChamado.Text = "Status:";
            // 
            // lblChamadoID
            // 
            this.lblChamadoID.AutoSize = true;
            this.lblChamadoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamadoID.Location = new System.Drawing.Point(28, 80);
            this.lblChamadoID.Name = "lblChamadoID";
            this.lblChamadoID.Size = new System.Drawing.Size(97, 15);
            this.lblChamadoID.TabIndex = 7;
            this.lblChamadoID.Text = "Nº do Chamado:";
            // 
            // gbxAreaSolicitante
            // 
            this.gbxAreaSolicitante.Controls.Add(this.txtTitulo);
            this.gbxAreaSolicitante.Controls.Add(this.lblTitulo);
            this.gbxAreaSolicitante.Controls.Add(this.cbxCriticidade);
            this.gbxAreaSolicitante.Controls.Add(this.lblCriticidade);
            this.gbxAreaSolicitante.Controls.Add(this.mskDataInicial);
            this.gbxAreaSolicitante.Controls.Add(this.cbxStatusChamado);
            this.gbxAreaSolicitante.Controls.Add(this.txtChamadoID);
            this.gbxAreaSolicitante.Controls.Add(this.grdChamados);
            this.gbxAreaSolicitante.Controls.Add(this.btnNovoChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblStatusChamado);
            this.gbxAreaSolicitante.Controls.Add(this.lblChamadoID);
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
            // mskDataInicial
            // 
            this.mskDataInicial.Location = new System.Drawing.Point(303, 98);
            this.mskDataInicial.Mask = "00/00/0000";
            this.mskDataInicial.Name = "mskDataInicial";
            this.mskDataInicial.Size = new System.Drawing.Size(100, 20);
            this.mskDataInicial.TabIndex = 13;
            this.mskDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // cbxStatusChamado
            // 
            this.cbxStatusChamado.DataSource = this.sTATUSCHAMADOBindingSource;
            this.cbxStatusChamado.DisplayMember = "NOME_STATUS_CHAMADO";
            this.cbxStatusChamado.FormattingEnabled = true;
            this.cbxStatusChamado.Location = new System.Drawing.Point(163, 98);
            this.cbxStatusChamado.Name = "cbxStatusChamado";
            this.cbxStatusChamado.Size = new System.Drawing.Size(121, 21);
            this.cbxStatusChamado.TabIndex = 12;
            this.cbxStatusChamado.ValueMember = "ID_STATUS_CHAMADO";
            // 
            // txtChamadoID
            // 
            this.txtChamadoID.Location = new System.Drawing.Point(31, 98);
            this.txtChamadoID.Name = "txtChamadoID";
            this.txtChamadoID.Size = new System.Drawing.Size(104, 20);
            this.txtChamadoID.TabIndex = 9;
            // 
            // grdChamados
            // 
            this.grdChamados.AllowUserToAddRows = false;
            this.grdChamados.AllowUserToDeleteRows = false;
            this.grdChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChamados.Location = new System.Drawing.Point(30, 145);
            this.grdChamados.Name = "grdChamados";
            this.grdChamados.ReadOnly = true;
            this.grdChamados.Size = new System.Drawing.Size(571, 264);
            this.grdChamados.TabIndex = 8;
            // 
            // cbxCriticidade
            // 
            this.cbxCriticidade.DataSource = this.nIVELCHAMADOBindingSource;
            this.cbxCriticidade.DisplayMember = "NOME_NIVEL_CHAMADO";
            this.cbxCriticidade.FormattingEnabled = true;
            this.cbxCriticidade.Location = new System.Drawing.Point(425, 98);
            this.cbxCriticidade.Name = "cbxCriticidade";
            this.cbxCriticidade.Size = new System.Drawing.Size(121, 21);
            this.cbxCriticidade.TabIndex = 15;
            this.cbxCriticidade.ValueMember = "ID_NIVEL_CHAMADO";
            // 
            // lblCriticidade
            // 
            this.lblCriticidade.AutoSize = true;
            this.lblCriticidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticidade.Location = new System.Drawing.Point(422, 80);
            this.lblCriticidade.Name = "lblCriticidade";
            this.lblCriticidade.Size = new System.Drawing.Size(68, 15);
            this.lblCriticidade.TabIndex = 14;
            this.lblCriticidade.Text = "Criticidade:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(558, 99);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(104, 20);
            this.txtTitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(555, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 15);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Título:";
            // 
            // db_JIRAPIM
            // 
            this.db_JIRAPIM.DataSetName = "db_JIRAPIM";
            this.db_JIRAPIM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbJIRAPIMBindingSource
            // 
            this.dbJIRAPIMBindingSource.DataSource = this.db_JIRAPIM;
            this.dbJIRAPIMBindingSource.Position = 0;
            // 
            // sTATUSCHAMADOBindingSource
            // 
            this.sTATUSCHAMADOBindingSource.DataMember = "STATUS_CHAMADO";
            this.sTATUSCHAMADOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
            // 
            // sTATUS_CHAMADOTableAdapter
            // 
            this.sTATUS_CHAMADOTableAdapter.ClearBeforeFill = true;
            // 
            // nIVELCHAMADOBindingSource
            // 
            this.nIVELCHAMADOBindingSource.DataMember = "NIVEL_CHAMADO";
            this.nIVELCHAMADOBindingSource.DataSource = this.db_JIRAPIM;
            // 
            // nIVEL_CHAMADOTableAdapter
            // 
            this.nIVEL_CHAMADOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 466);
            this.Controls.Add(this.gbxAreaSolicitante);
            this.Name = "FrmChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados";
            this.Load += new System.EventHandler(this.FrmChamados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmChamados_KeyDown);
            this.gbxAreaSolicitante.ResumeLayout(false);
            this.gbxAreaSolicitante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSCHAMADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELCHAMADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Button btnPesquisarChamado;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblStatusChamado;
        private System.Windows.Forms.Label lblChamadoID;
        private System.Windows.Forms.GroupBox gbxAreaSolicitante;
        private System.Windows.Forms.ComboBox cbxStatusChamado;
        private System.Windows.Forms.TextBox txtChamadoID;
        private System.Windows.Forms.DataGridView grdChamados;
        private System.Windows.Forms.MaskedTextBox mskDataInicial;
        private System.Windows.Forms.ComboBox cbxCriticidade;
        private System.Windows.Forms.Label lblCriticidade;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource dbJIRAPIMBindingSource;
        private db_JIRAPIM db_JIRAPIM;
        private System.Windows.Forms.BindingSource sTATUSCHAMADOBindingSource;
        private db_JIRAPIMTableAdapters.STATUS_CHAMADOTableAdapter sTATUS_CHAMADOTableAdapter;
        private System.Windows.Forms.BindingSource nIVELCHAMADOBindingSource;
        private db_JIRAPIMTableAdapters.NIVEL_CHAMADOTableAdapter nIVEL_CHAMADOTableAdapter;
    }
}