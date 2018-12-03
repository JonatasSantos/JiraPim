namespace JiraPim
{
    partial class FrmCadastrarFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.pERFILUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbJIRAPIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_JIRAPIM = new JiraPim.db_JIRAPIM();
            this.btnIncluirCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.cARGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.mskTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gbxDadosProfissionais = new System.Windows.Forms.GroupBox();
            this.cARGOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.CARGOTableAdapter();
            this.pERFIL_USUARIOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.PERFIL_USUARIOTableAdapter();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pERFILUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).BeginInit();
            this.gbxDadosPessoais.SuspendLayout();
            this.gbxDadosProfissionais.SuspendLayout();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(115, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:* ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Enabled = false;
            this.lblTipo.Location = new System.Drawing.Point(280, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo: ";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(52, 22);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(123, 53);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:*";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pERFILUSUARIOBindingSource, "ID_PERFIL_USUARIO", true));
            this.cbxTipo.DataSource = this.pERFILUSUARIOBindingSource;
            this.cbxTipo.DisplayMember = "NOME_PERFIL_USUARIO";
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(316, 19);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(176, 21);
            this.cbxTipo.TabIndex = 19;
            this.cbxTipo.ValueMember = "ID_PERFIL_USUARIO";
            // 
            // pERFILUSUARIOBindingSource
            // 
            this.pERFILUSUARIOBindingSource.DataMember = "PERFIL_USUARIO";
            this.pERFILUSUARIOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
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
            // btnIncluirCadastro
            // 
            this.btnIncluirCadastro.Location = new System.Drawing.Point(126, 436);
            this.btnIncluirCadastro.Name = "btnIncluirCadastro";
            this.btnIncluirCadastro.Size = new System.Drawing.Size(143, 23);
            this.btnIncluirCadastro.TabIndex = 23;
            this.btnIncluirCadastro.Text = "Incluir Cadastro";
            this.btnIncluirCadastro.UseVisualStyleBackColor = true;
            this.btnIncluirCadastro.Click += new System.EventHandler(this.btnIncluirCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(355, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(57, 23);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(159, 50);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 2;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbxCargo
            // 
            this.cbxCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cARGOBindingSource, "ID_CARGO", true));
            this.cbxCargo.DataSource = this.cARGOBindingSource;
            this.cbxCargo.DisplayMember = "NOME_CARGO";
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(95, 19);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(177, 21);
            this.cbxCargo.TabIndex = 18;
            this.cbxCargo.ValueMember = "ID_CARGO";
            this.cbxCargo.SelectedIndexChanged += new System.EventHandler(this.cbxCargo_SelectedIndexChanged);
            // 
            // cARGOBindingSource
            // 
            this.cARGOBindingSource.DataMember = "CARGO";
            this.cARGOBindingSource.DataSource = this.dbJIRAPIMBindingSource;
            // 
            // mskTel1
            // 
            this.mskTel1.Location = new System.Drawing.Point(159, 102);
            this.mskTel1.Mask = "(00)00000-0000";
            this.mskTel1.Name = "mskTel1";
            this.mskTel1.Size = new System.Drawing.Size(100, 20);
            this.mskTel1.TabIndex = 6;
            this.mskTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(415, 51);
            this.mskRG.Mask = "00.000.000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(100, 20);
            this.mskRG.TabIndex = 3;
            this.mskRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(159, 76);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 4;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataAdmissao
            // 
            this.mskDataAdmissao.Location = new System.Drawing.Point(415, 77);
            this.mskDataAdmissao.Mask = "00/00/0000";
            this.mskDataAdmissao.Name = "mskDataAdmissao";
            this.mskDataAdmissao.Size = new System.Drawing.Size(100, 20);
            this.mskDataAdmissao.TabIndex = 5;
            this.mskDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(159, 158);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 20);
            this.mskCEP.TabIndex = 10;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(413, 187);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(355, 201);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(297, 106);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(112, 13);
            this.lblTel2.TabIndex = 0;
            this.lblTel2.Text = "Telefone 2 (Opcional):";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(102, 105);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(55, 13);
            this.lblTel1.TabIndex = 0;
            this.lblTel1.Text = "Telefone: ";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(83, 213);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(357, 227);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 0;
            this.lblPais.Text = "País:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(124, 161);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(112, 239);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(113, 135);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular:";
            this.lblCelular.Click += new System.EventHandler(this.lblCelular_Click);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(383, 54);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(30, 13);
            this.lblRG.TabIndex = 0;
            this.lblRG.Text = "RG:*";
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(314, 80);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(99, 13);
            this.lblDataAdmissao.TabIndex = 0;
            this.lblDataAdmissao.Text = "Data de admissão:*";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(48, 79);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(109, 13);
            this.lblDataNascimento.TabIndex = 0;
            this.lblDataNascimento.Text = "Data de nascimento:*";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(99, 187);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(295, 242);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 0;
            this.lblUF.Text = "UF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(282, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(159, 184);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(243, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(159, 236);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(319, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(464, 184);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(51, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(392, 198);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(159, 132);
            this.mskCel.Mask = "(00)00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(100, 20);
            this.mskCel.TabIndex = 8;
            this.mskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTel2
            // 
            this.mskTel2.Location = new System.Drawing.Point(415, 103);
            this.mskTel2.Mask = "(00)00000-0000";
            this.mskTel2.Name = "mskTel2";
            this.mskTel2.Size = new System.Drawing.Size(100, 20);
            this.mskTel2.TabIndex = 7;
            this.mskTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(392, 224);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 17;
            // 
            // cbxUF
            // 
            this.cbxUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(319, 236);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(45, 21);
            this.cbxUF.TabIndex = 16;
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.txtPais);
            this.gbxDadosPessoais.Controls.Add(this.lblPais);
            this.gbxDadosPessoais.Controls.Add(this.txtBairro);
            this.gbxDadosPessoais.Controls.Add(this.lblBairro);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(23, 12);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(526, 268);
            this.gbxDadosPessoais.TabIndex = 0;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados Pessoais";
            // 
            // gbxDadosProfissionais
            // 
            this.gbxDadosProfissionais.Controls.Add(this.cbxTipo);
            this.gbxDadosProfissionais.Controls.Add(this.lblTipo);
            this.gbxDadosProfissionais.Controls.Add(this.lblCargo);
            this.gbxDadosProfissionais.Controls.Add(this.cbxCargo);
            this.gbxDadosProfissionais.Location = new System.Drawing.Point(23, 286);
            this.gbxDadosProfissionais.Name = "gbxDadosProfissionais";
            this.gbxDadosProfissionais.Size = new System.Drawing.Size(526, 61);
            this.gbxDadosProfissionais.TabIndex = 0;
            this.gbxDadosProfissionais.TabStop = false;
            this.gbxDadosProfissionais.Text = "Dados Profissionais";
            // 
            // cARGOTableAdapter
            // 
            this.cARGOTableAdapter.ClearBeforeFill = true;
            // 
            // pERFIL_USUARIOTableAdapter
            // 
            this.pERFIL_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(159, 210);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 13;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.txtConfirmarSenha);
            this.gbxLogin.Controls.Add(this.lblConfirmarSenha);
            this.gbxLogin.Controls.Add(this.txtSenha);
            this.gbxLogin.Controls.Add(this.txtLogin);
            this.gbxLogin.Controls.Add(this.lblSenha);
            this.gbxLogin.Controls.Add(this.lblLogin);
            this.gbxLogin.Location = new System.Drawing.Point(23, 353);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(526, 77);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Cadastrar Login";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(392, 48);
            this.txtConfirmarSenha.MaxLength = 8;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarSenha.TabIndex = 22;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(301, 51);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(88, 13);
            this.lblConfirmarSenha.TabIndex = 0;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(392, 22);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 21;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(165, 22);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(132, 20);
            this.txtLogin.TabIndex = 20;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(347, 25);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(123, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // FrmCadastrarFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(575, 518);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.mskTel2);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.mskDataAdmissao);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.mskRG);
            this.Controls.Add(this.mskTel1);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIncluirCadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbxDadosPessoais);
            this.Controls.Add(this.gbxDadosProfissionais);
            this.KeyPreview = true;
            this.Name = "FrmCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pERFILUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbJIRAPIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOBindingSource)).EndInit();
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.gbxDadosProfissionais.ResumeLayout(false);
            this.gbxDadosProfissionais.PerformLayout();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnIncluirCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.MaskedTextBox mskTel1;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskDataAdmissao;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.MaskedTextBox mskTel2;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.GroupBox gbxDadosProfissionais;
        private System.Windows.Forms.BindingSource dbJIRAPIMBindingSource;
        private db_JIRAPIM db_JIRAPIM;
        private System.Windows.Forms.BindingSource cARGOBindingSource;
        private db_JIRAPIMTableAdapters.CARGOTableAdapter cARGOTableAdapter;
        private System.Windows.Forms.BindingSource pERFILUSUARIOBindingSource;
        private db_JIRAPIMTableAdapters.PERFIL_USUARIOTableAdapter pERFIL_USUARIOTableAdapter;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
    }
}