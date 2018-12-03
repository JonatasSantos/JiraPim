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
    public partial class FrmChamadoSolicitante : Form
    {
        MdlChamado _mdlChamado = new MdlChamado();
        CtlChamadoSolicitante _ctlChamadoSolicitante = new CtlChamadoSolicitante();

        public FrmChamadoSolicitante()
        {
            InitializeComponent();
        }

        private void FrmAberturaChamado_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmAberturaChamado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_JIRAPIM.NIVEL_CHAMADO'. Você pode movê-la ou removê-la conforme necessário.
            this.nIVEL_CHAMADOTableAdapter.Fill(this.db_JIRAPIM.NIVEL_CHAMADO);

        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            bool retorno;

            if (txtTitulo.Text == "" && cbxCriticidade.Text == "" && rtxtDescricao.Text == "")
            {
                MessageBox.Show("Há campo não preenchido, por favor, preencha todos para poder abrir o chamado corretamente.");
                return;
            }

            _mdlChamado.SetTitulo(txtTitulo.Text);
            _mdlChamado.SetCategoria(Convert.ToInt32(cbxCriticidade.SelectedValue));
            _mdlChamado.SetDescricao(rtxtDescricao.Text);

            retorno = _ctlChamadoSolicitante.abrirChamado(_mdlChamado);
            if (retorno)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso.");
                foreach (Control item in Controls)
                {
                    if (item.GetType().Name == "TextBox" || item.GetType().Name == "ComboBox" || item.GetType().Name == "MaskedTextBox")
                    {
                        item.ResetText();
                    }
                }
            }
        }

        private void txtTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void rtxtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTitulo.Text == "" && rtxtDescricao.Text == "" && cbxCriticidade.Text == "")
            {
                btnAbrirChamado.Enabled = false;
            }
            else
            {
                btnAbrirChamado.Enabled = true;
            }
        }

        private void rtxtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTitulo.Text == "" && rtxtDescricao.Text == "" && cbxCriticidade.Text == "")
            {
                btnAbrirChamado.Enabled = false;
            }
            else
            {
                btnAbrirChamado.Enabled = true;
            }
        }
    }
}
