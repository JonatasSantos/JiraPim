using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraPim
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frmFuncionarios = new FrmFuncionarios();
            frmFuncionarios.ShowDialog();
        }

        private void BtnChamados_Click(object sender, EventArgs e)
        {
            FrmChamados frmChamados = new FrmChamados();
            frmChamados.ShowDialog();
        }

        private void BtnBoard_Click(object sender, EventArgs e)
        {
            FrmBoard frmBoard = new FrmBoard();
            frmBoard.ShowDialog();
        }

        private void FrmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
