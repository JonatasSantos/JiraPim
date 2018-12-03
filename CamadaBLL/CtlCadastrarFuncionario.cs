using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaEntidades;
using CamadaDAL;
using System.Text.RegularExpressions;

namespace CamadaBLL
{
    public class CtlCadastrarFuncionario
    {
        public bool result;
        public bool incluirFuncionario(MdlFuncionario _mdlFuncionario)
        {
            DalCadastrarFuncionario _DalCadastrarFuncionario = new DalCadastrarFuncionario();
            _DalCadastrarFuncionario.Conectar();
            result = _DalCadastrarFuncionario.Incluir(_mdlFuncionario);
            return result;
        }

        public MdlFuncionario carregarFuncionario(MdlFuncionario _mdlFuncionario)
        {
            DalCadastrarFuncionario _DalCadastrarFuncionario = new DalCadastrarFuncionario();
            MdlFuncionario mdlFuncionario = new MdlFuncionario();
            _DalCadastrarFuncionario.Conectar();
            mdlFuncionario = _DalCadastrarFuncionario.getFuncionario(_mdlFuncionario);
            return mdlFuncionario;
        }
    }

}
