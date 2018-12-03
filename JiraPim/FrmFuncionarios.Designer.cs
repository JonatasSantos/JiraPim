namespace JiraPim
{
    partial class FrmFuncionarios
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
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grdFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.cARGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbJIRAPIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_JIRAPIM = new JiraPim.db_JIRAPIM();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.dEPARTAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cARGOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.CARGOTableAdapter();
            this.dEPARTAMENTOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.DEPARTAMENTOTableAdapter();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.FUNCIONARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(28, 25);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(127, 23);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "Cadastrar Funcionário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(569, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(465, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(262, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(267, 97);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // grdFuncionarios
            // 
            this.grdFuncionarios.AllowUserToAddRows = false;
            this.grdFuncionarios.AllowUserToDeleteRows = false;
            this.grdFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFuncionarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdFuncionarios.Location = new System.Drawing.Point(12, 185);
            this.grdFuncionarios.Name = "grdFuncionarios";
            this.grdFuncionarios.ReadOnly = true;
            this.grdFuncionarios.Size = new System.Drawing.Size(632, 270);
            this.grdFuncionarios.TabIndex = 6;
            this.grdFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellContentClick);
            this.grdFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFuncionarios_CellDoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbxCargo
            // 
            this.cbxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCargo.DataSource = this.cARGOBindingSource;
            this.cbxCargo.DisplayMember = "NOME_CARGO";
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(308, 94);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(121, 21);
            this.cbxCargo.TabIndex = 2;
            this.cbxCargo.ValueMember = "ID_CARGO";
            // 
            // cARGOBindingSource
            // 
            this.cARGOBindingSource.DataMember = "CARGO";
            this.cARGOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
            // 
            // dbJIRAPIMBindingSource
            // 
            this.dbJIRAPIMBindingSource.DataSource = this.db_JIRAPIM;
            this.dbJIRAPIMBindingSource.Position = 0;
            // 
            // db_JIRAPIM
            // 
            this.db_JIRAPIM.DataSetName = "db_JIRAPIM";
            this.db_JIRAPIM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbxStatus.Location = new System.Drawing.Point(308, 130);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 4;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDepartamento.DataSource = this.dEPARTAMENTOBindingSource;
            this.cbxDepartamento.DisplayMember = "NOME_DEPARTAMENTO";
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(111, 130);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cbxDepartamento.TabIndex = 3;
            this.cbxDepartamento.ValueMember = "ID_DEPARTAMENTO";
            // 
            // dEPARTAMENTOBindingSource
            // 
            this.dEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO";
            this.dEPARTAMENTOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(25, 134);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 16;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cARGOTableAdapter
            // 
            this.cARGOTableAdapter.ClearBeforeFill = true;
            // 
            // dEPARTAMENTOTableAdapter
            // 
            this.dEPARTAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 467);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.grdFuncionarios);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "FrmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView grdFuncionarios;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.BindingSource dbJIRAPIMBindingSource;
        private db_JIRAPIM db_JIRAPIM;
        private System.Windows.Forms.BindingSource cARGOBindingSource;
        private db_JIRAPIMTableAdapters.CARGOTableAdapter cARGOTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTAMENTOBindingSource;
        private db_JIRAPIMTableAdapters.DEPARTAMENTOTableAdapter dEPARTAMENTOTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private db_JIRAPIMTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
    }
}