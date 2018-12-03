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
using CamadaEntidades;

namespace JiraPim
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MdlFuncionario retFuncionario = new MdlFuncionario();
            MdlFuncionario _mdlFuncionario = new MdlFuncionario();
            CtlLogin ctl = new CtlLogin();
            

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por favor, insira o usuário e senha.");
                return;
            }

            _mdlFuncionario.SetLogin(txtUsuario.Text);
            _mdlFuncionario.SetSenha(txtSenha.Text);

            retFuncionario = ctl.FazerLogin(_mdlFuncionario);
            if (retFuncionario.GetId() == 0)
            {
                MessageBox.Show("Usuário não encontrado. Favor verificar se usuário e senha estão corretos.");
            }
            else
            {
                this.Hide();
                switch (retFuncionario.GetTipo())
                {
                    case 1:
                        FrmInicio frmInicio = new FrmInicio();
                        abrirAplicacao(frmInicio);
                        break;
                    case 2:
                        FrmInicio frmInicio2 = new FrmInicio();
                        abrirAplicacao(frmInicio2);
                        break;
                    case 3:
                        FrmBoard frmBoard = new FrmBoard();
                        abrirAplicacao(frmBoard);
                        break;
                    case 4:
                        FrmChamados frmChamados = new FrmChamados();
                        abrirAplicacao(frmChamados);
                        break;
                    default:
                        MessageBox.Show("Algum problema ocorreu. Por favor, contate o desenvolvimento.");
                        break;
                }
            }
        }
        
        public void abrirAplicacao(Form form)
        {
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
