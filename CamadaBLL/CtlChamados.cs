using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDAL;
using CamadaEntidades;
using System.Collections.ObjectModel;
using System.Data;

namespace CamadaBLL
{
    public class CtlChamados
    {
        public DataTable mdlChamados = new DataTable();
        public DalChamados dalChamados = new DalChamados();

        public DataTable retChamados()
        {
            dalChamados.Conectar();
            mdlChamados = dalChamados.retChamados();
            return mdlChamados;
        }

        public DataTable pesquisarChamados(MdlChamado Chamado)
        {
            dalChamados.Conectar();
            mdlChamados = dalChamados.pesquisarChamados(Chamado);
            return mdlChamados;
        }
    }
}
