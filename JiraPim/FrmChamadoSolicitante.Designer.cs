namespace JiraPim
{
    partial class FrmChamadoSolicitante
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
            this.btnHomologarChamado = new System.Windows.Forms.Button();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnReprovarHomolog = new System.Windows.Forms.Button();
            this.gbxAberturaChamado = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCriticidade = new System.Windows.Forms.Label();
            this.cbxCriticidade = new System.Windows.Forms.ComboBox();
            this.nIVELCHAMADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_JIRAPIM = new JiraPim.db_JIRAPIM();
            this.grdConversa = new System.Windows.Forms.DataGridView();
            this.barProgressoChamado = new System.Windows.Forms.ProgressBar();
            this.lblBarProgressoChamado = new System.Windows.Forms.Label();
            this.nIVEL_CHAMADOTableAdapter = new JiraPim.db_JIRAPIMTableAdapters.NIVEL_CHAMADOTableAdapter();
            this.gbxAberturaChamado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELCHAMADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConversa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomologarChamado
            // 
            this.btnHomologarChamado.Enabled = false;
            this.btnHomologarChamado.Location = new System.Drawing.Point(252, 30);
            this.btnHomologarChamado.Name = "btnHomologarChamado";
            this.btnHomologarChamado.Size = new System.Drawing.Size(75, 23);
            this.btnHomologarChamado.TabIndex = 0;
            this.btnHomologarChamado.Text = "Homologar";
            this.btnHomologarChamado.UseVisualStyleBackColor = true;
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.Enabled = false;
            this.btnAbrirChamado.Location = new System.Drawing.Point(221, 325);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirChamado.TabIndex = 1;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = true;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(691, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnReprovarHomolog
            // 
            this.btnReprovarHomolog.Enabled = false;
            this.btnReprovarHomolog.Location = new System.Drawing.Point(409, 30);
            this.btnReprovarHomolog.Name = "btnReprovarHomolog";
            this.btnReprovarHomolog.Size = new System.Drawing.Size(132, 23);
            this.btnReprovarHomolog.TabIndex = 3;
            this.btnReprovarHomolog.Text = "Reprovar homologação";
            this.btnReprovarHomolog.UseVisualStyleBackColor = true;
            // 
            // gbxAberturaChamado
            // 
            this.gbxAberturaChamado.Controls.Add(this.lblDescricao);
            this.gbxAberturaChamado.Controls.Add(this.rtxtDescricao);
            this.gbxAberturaChamado.Controls.Add(this.lblTitulo);
            this.gbxAberturaChamado.Controls.Add(this.txtTitulo);
            this.gbxAberturaChamado.Controls.Add(this.lblCriticidade);
            this.gbxAberturaChamado.Controls.Add(this.btnVoltar);
            this.gbxAberturaChamado.Controls.Add(this.cbxCriticidade);
            this.gbxAberturaChamado.Controls.Add(this.btnAbrirChamado);
            this.gbxAberturaChamado.Controls.Add(this.grdConversa);
            this.gbxAberturaChamado.Location = new System.Drawing.Point(23, 12);
            this.gbxAberturaChamado.Name = "gbxAberturaChamado";
            this.gbxAberturaChamado.Size = new System.Drawing.Size(772, 372);
            this.gbxAberturaChamado.TabIndex = 5;
            this.gbxAberturaChamado.TabStop = false;
            this.gbxAberturaChamado.Text = "Chamado";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(22, 170);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição:";
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Location = new System.Drawing.Point(25, 186);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(296, 133);
            this.rtxtDescricao.TabIndex = 10;
            this.rtxtDescricao.Text = "";
            this.rtxtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtDescricao_KeyDown);
            this.rtxtDescricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtxtDescricao_KeyUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(64, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(108, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(213, 20);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitulo_KeyDown);
            this.txtTitulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitulo_KeyUp);
            // 
            // lblCriticidade
            // 
            this.lblCriticidade.AutoSize = true;
            this.lblCriticidade.Location = new System.Drawing.Point(43, 110);
            this.lblCriticidade.Name = "lblCriticidade";
            this.lblCriticidade.Size = new System.Drawing.Size(59, 13);
            this.lblCriticidade.TabIndex = 7;
            this.lblCriticidade.Text = "Criticidade:";
            // 
            // cbxCriticidade
            // 
            this.cbxCriticidade.DataSource = this.nIVELCHAMADOBindingSource;
            this.cbxCriticidade.DisplayMember = "NOME_NIVEL_CHAMADO";
            this.cbxCriticidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriticidade.FormattingEnabled = true;
            this.cbxCriticidade.Location = new System.Drawing.Point(108, 107);
            this.cbxCriticidade.Name = "cbxCriticidade";
            this.cbxCriticidade.Size = new System.Drawing.Size(121, 21);
            this.cbxCriticidade.TabIndex = 6;
            this.cbxCriticidade.ValueMember = "ID_NIVEL_CHAMADO";
            // 
            // nIVELCHAMADOBindingSource
            // 
            this.nIVELCHAMADOBindingSource.DataMember = "NIVEL_CHAMADO";
            this.nIVELCHAMADOBindingSource.DataSource = this.db_JIRAPIM;
            // 
            // db_JIRAPIM
            // 
            this.db_JIRAPIM.DataSetName = "db_JIRAPIM";
            this.db_JIRAPIM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdConversa
            // 
            this.grdConversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConversa.Location = new System.Drawing.Point(348, 65);
            this.grdConversa.Name = "grdConversa";
            this.grdConversa.Size = new System.Drawing.Size(377, 253);
            this.grdConversa.TabIndex = 0;
            // 
            // barProgressoChamado
            // 
            this.barProgressoChamado.Location = new System.Drawing.Point(207, 448);
            this.barProgressoChamado.Name = "barProgressoChamado";
            this.barProgressoChamado.Size = new System.Drawing.Size(398, 23);
            this.barProgressoChamado.TabIndex = 8;
            // 
            // lblBarProgressoChamado
            // 
            this.lblBarProgressoChamado.AutoSize = true;
            this.lblBarProgressoChamado.Location = new System.Drawing.Point(204, 432);
            this.lblBarProgressoChamado.Name = "lblBarProgressoChamado";
            this.lblBarProgressoChamado.Size = new System.Drawing.Size(211, 13);
            this.lblBarProgressoChamado.TabIndex = 5;
            this.lblBarProgressoChamado.Text = "Tempo máximo de resposta da SLA (3 dias)";
            // 
            // nIVEL_CHAMADOTableAdapter
            // 
            this.nIVEL_CHAMADOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmChamadoSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 483);
            this.Controls.Add(this.barProgressoChamado);
            this.Controls.Add(this.btnReprovarHomolog);
            this.Controls.Add(this.btnHomologarChamado);
            this.Controls.Add(this.gbxAberturaChamado);
            this.Controls.Add(this.lblBarProgressoChamado);
            this.KeyPreview = true;
            this.Name = "FrmChamadoSolicitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamado";
            this.Load += new System.EventHandler(this.FrmAberturaChamado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAberturaChamado_KeyDown);
            this.gbxAberturaChamado.ResumeLayout(false);
            this.gbxAberturaChamado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIVELCHAMADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_JIRAPIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConversa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomologarChamado;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnReprovarHomolog;
        private System.Windows.Forms.GroupBox gbxAberturaChamado;
        private System.Windows.Forms.Label lblCriticidade;
        private System.Windows.Forms.ComboBox cbxCriticidade;
        private System.Windows.Forms.Label lblBarProgressoChamado;
        private System.Windows.Forms.DataGridView grdConversa;
        private System.Windows.Forms.ProgressBar barProgressoChamado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private db_JIRAPIM db_JIRAPIM;
        private System.Windows.Forms.BindingSource nIVELCHAMADOBindingSource;
        private db_JIRAPIMTableAdapters.NIVEL_CHAMADOTableAdapter nIVEL_CHAMADOTableAdapter;
    }
}