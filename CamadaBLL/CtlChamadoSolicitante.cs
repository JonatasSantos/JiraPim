using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaEntidades;
using CamadaDAL;

namespace CamadaBLL
{
    public class CtlChamadoSolicitante
    {
        DalChamadoSolicitante _dalChamadoSolicitante = new DalChamadoSolicitante();

        public bool result;
        public bool abrirChamado(MdlChamado _mdlChamado)
        {
            DalChamadoSolicitante _dalChamadoSolicitante = new DalChamadoSolicitante();
            _dalChamadoSolicitante.Conectar();
            result = _dalChamadoSolicitante.abrirChamado(_mdlChamado);
            return result;
        }

    }
}
