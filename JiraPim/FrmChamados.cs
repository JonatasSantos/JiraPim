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
    public partial class FrmChamados : Form
    {
        MdlChamado _mdlChamado = new MdlChamado();
        //CtlChamado _ctlChamado = new CtlChamado();
        CtlChamados ctlChamados = new CtlChamados();

        public FrmChamados()
        {
            InitializeComponent();
        }

        private void btnPesquisarChamado_Click(object sender, EventArgs e)
        {
            int chamadoID;
            if (txtChamadoID.Text == "" && cbxStatusChamado.Text == "" && mskDataInicial.Text == "" && cbxCriticidade.Text == ""
                && txtTitulo.Text == "")
            {
                MessageBox.Show("Por favor, preencher um dos campos para poder realizar a pesquisa.");
                return;
            }

            //status = (cbxStatusChamado.SelectedItem.ToString() == "ATIVO") ? 1 : 0;
            chamadoID = (txtChamadoID.Text == "") ? 0 : Convert.ToInt32(txtChamadoID.Text);

            grdChamados.DataSource = -1;
            _mdlChamado.SetCodigo(chamadoID);
            _mdlChamado.SetTitulo(txtTitulo.Text);
            _mdlChamado.SetStatus(Convert.ToInt32(cbxStatusChamado.SelectedValue));
            _mdlChamado.SetDataHoraAbertura(Convert.ToDateTime(mskDataInicial.Text));
            _mdlChamado.SetCategoria(Convert.ToInt32(cbxCriticidade.SelectedValue));

            grdChamados.DataSource = ctlChamados.pesquisarChamados(_mdlChamado);
        }

        private void FrmChamados_KeyDown(object sender, KeyEventArgs e)
        {
            if (true)
            {
                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            
        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            FrmChamadoSolicitante _frm = new FrmChamadoSolicitante();
            _frm.ShowDialog();
        }

        private void FrmChamados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.NIVEL_CHAMADO'. Você pode movê-la ou removê-la conforme necessário.
            this.nIVEL_CHAMADOTableAdapter.Fill(this.db_JIRAPIM.NIVEL_CHAMADO);
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.STATUS_CHAMADO'. Você pode movê-la ou removê-la conforme necessário.
            this.sTATUS_CHAMADOTableAdapter.Fill(this.db_JIRAPIM.STATUS_CHAMADO);

        }
    }
}
