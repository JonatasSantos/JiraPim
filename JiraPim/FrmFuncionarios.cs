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
    public partial class FrmFuncionarios : Form
    {
        MdlFuncionario _mdlFuncionario = new MdlFuncionario();
        CtlCadastrarFuncionario _ctlCadastrarFuncionario = new CtlCadastrarFuncionario();
        CtlFuncionarios ctlFuncionarios = new CtlFuncionarios();

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastrarFuncionario _frm = new FrmCadastrarFuncionario();
            _frm.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int status;
            if (txtNome.Text == "" && cbxCargo.Text == "" && cbxDepartamento.Text == "" && cbxStatus.Text == "")
            {
                MessageBox.Show("Por favor, preencher um dos campos.");
                return;
            }

            status = (cbxStatus.SelectedItem.ToString() == "ATIVO") ? 1 : 0;

            grdFuncionarios.DataSource = -1;
            _mdlFuncionario.SetNome(txtNome.Text);
            _mdlFuncionario.SetCargo(Convert.ToInt32(cbxCargo.SelectedValue));
            _mdlFuncionario.SetDepartamento(Convert.ToInt32(cbxDepartamento.SelectedValue));
            _mdlFuncionario.SetStatus(status);

            grdFuncionarios.DataSource = ctlFuncionarios.pesquisarFuncionarios(_mdlFuncionario);
            grdFuncionarios.Columns["Código"].Visible = false;
        }

        private void grdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.DEPARTAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.dEPARTAMENTOTableAdapter.Fill(this.db_JIRAPIM.DEPARTAMENTO);
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.CARGO'. Você pode movê-la ou removê-la conforme necessário.
            this.cARGOTableAdapter.Fill(this.db_JIRAPIM.CARGO);
            cbxCargo.SelectedIndex = cbxDepartamento.SelectedIndex = -1;
            cbxStatus.SelectedItem = "ATIVO";
            grdFuncionarios.DataSource = ctlFuncionarios.retFuncionarios();
            grdFuncionarios.Columns["Código"].Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(Keys.Escape))
            {
                Close();
            }
        }

        private void grdFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MdlFuncionario funcionarioID = new MdlFuncionario();

            funcionarioID.SetId(Convert.ToInt32(grdFuncionarios.Rows[e.RowIndex].Cells["Código"].Value));
            FrmCadastrarFuncionario _FrmCadastrarFuncionario = new FrmCadastrarFuncionario(funcionarioID);
            _FrmCadastrarFuncionario.ShowDialog();
            
        }
        
    }
}
