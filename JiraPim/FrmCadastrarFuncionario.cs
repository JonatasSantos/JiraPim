using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaBLL;
using CamadaDAL;
using CamadaEntidades;

namespace JiraPim
{
    public partial class FrmCadastrarFuncionario : Form
    {
        CtlCadastrarFuncionario _ctlCadastrarFuncionario = new CtlCadastrarFuncionario();

        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        public FrmCadastrarFuncionario(MdlFuncionario funcionario)
        {
            InitializeComponent();
            funcionario = _ctlCadastrarFuncionario.carregarFuncionario(funcionario);
            txtNome.Text = funcionario.GetNome();
            mskCPF.Text = funcionario.GetCPF();
            mskRG.Text = funcionario.GetRG();
            mskDataNascimento.Text = funcionario.GetDataNascimento().ToString();
            mskDataAdmissao.Text = funcionario.GetDataAdmissao().ToString();
            txtEmail.Text = funcionario.GetEmail();
            mskCEP.Text = funcionario.GetCEP();
            txtEndereco.Text = funcionario.GetEndereco();
            txtNumero.Text = funcionario.GetNumero().ToString();
            txtComplemento.Text = funcionario.GetComplemento();
            txtBairro.Text = funcionario.GetBairro();
            txtCidade.Text = funcionario.GetCidade();
            cbxUF.SelectedValue = funcionario.GetUf();
            txtPais.Text = funcionario.GetPais();
            cbxCargo.SelectedValue = funcionario.GetCargo();
            cbxTipo.SelectedValue = funcionario.GetTipo();
            txtLogin.Text = funcionario.GetLogin();
            txtSenha.Text = funcionario.GetSenha();
            txtConfirmarSenha.Text = funcionario.GetSenha();
            gbxLogin.Visible = false;
        }

        private void btnIncluirCadastro_Click(object sender, EventArgs e)
        {
            MdlFuncionario _mdlFuncionario = new MdlFuncionario();
            
            bool retorno;
            if (txtNome.Text != "" && mskCPF.Text != "" && mskRG.Text != "" && mskDataNascimento.Text != "" && mskDataAdmissao.Text != "" && txtEmail.Text != "" && 
                mskCEP.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtComplemento.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" &&
                cbxUF.Text != "" && txtPais.Text != "" && cbxCargo.Text != "" && cbxTipo.Text != "" && txtLogin.Text != "" &&
                txtSenha.Text != "" && txtConfirmarSenha.Text != "")
            {
                if (txtSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("Senha Inválida");
                }

                _mdlFuncionario.SetNome(txtNome.Text);
                _mdlFuncionario.SetCPF(mskCPF.Text);
                _mdlFuncionario.SetRG(mskRG.Text);
                _mdlFuncionario.SetDataNascimento(Convert.ToDateTime(mskDataNascimento.Text));
                _mdlFuncionario.SetDataAdmissao(Convert.ToDateTime(mskDataAdmissao.Text));
                _mdlFuncionario.SetTel1(mskTel1.Text);
                _mdlFuncionario.SetTel2(mskTel2.Text);
                _mdlFuncionario.SetCelular(mskCel.Text);
                _mdlFuncionario.SetEmail(txtEmail.Text);
                _mdlFuncionario.SetCEP(mskCEP.Text);
                _mdlFuncionario.SetEndereco(txtEndereco.Text);
                _mdlFuncionario.SetNumero(Convert.ToInt32(txtNumero.Text));
                _mdlFuncionario.SetComplemento(txtComplemento.Text);
                _mdlFuncionario.SetBairro(txtBairro.Text);
                _mdlFuncionario.SetCidade(txtCidade.Text);
                _mdlFuncionario.SetUf(cbxUF.Text);
                _mdlFuncionario.SetPais(txtPais.Text);
                _mdlFuncionario.SetCargo(Convert.ToInt16(cbxCargo.SelectedValue));
                _mdlFuncionario.SetTipo(Convert.ToInt16(cbxTipo.SelectedValue));
                _mdlFuncionario.SetLogin(txtLogin.Text);
                _mdlFuncionario.SetSenha(txtSenha.Text);

                retorno = _ctlCadastrarFuncionario.incluirFuncionario(_mdlFuncionario);
                if (retorno)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso.");
                    foreach (Control item in Controls)
                    {
                        if (item.GetType().Name == "TextBox" || item.GetType().Name == "ComboBox" || item.GetType().Name == "MaskedTextBox")
                        {
                            item.Text = String.Empty;
                        }
                    } 
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, verificar se há campo(s) não preenchido(s).");
            }
        }
        
        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.PERFIL_USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.pERFIL_USUARIOTableAdapter.Fill(this.db_JIRAPIM.PERFIL_USUARIO);
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.CARGO'. Você pode movê-la ou removê-la conforme necessário.
            this.cARGOTableAdapter.Fill(this.db_JIRAPIM.CARGO);
            //cbxCargo.DataSource = db_JIRAPIM.Tables["CARGO"];
            //cbxCargo.DisplayMember = "
            txtNome.Focus();
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxCargo.Text = db_JIRAPIM.Tables["CARGO"]
        }

        private void FrmCadastrarFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


    
