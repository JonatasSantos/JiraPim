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
    public class CtlFuncionarios
    {
        public DataTable mdlFuncionarios = new DataTable();
        public DalFuncionarios dalFuncionarios = new DalFuncionarios();

        public DataTable retFuncionarios()
        {
            dalFuncionarios.Conectar();
            mdlFuncionarios = dalFuncionarios.retFuncionarios();
            return mdlFuncionarios;
        }

        public DataTable pesquisarFuncionarios(MdlFuncionario funcionario)
        {
            dalFuncionarios.Conectar();
            mdlFuncionarios = dalFuncionarios.pesquisarFuncionarios(funcionario);
            return mdlFuncionarios;
        }
    }
}
