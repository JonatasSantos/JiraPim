using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDAL;
using CamadaEntidades;

namespace CamadaBLL
{
    public class CtlLogin
    {
        DalLogin _dal = new DalLogin();
        MdlFuncionario funcionario = new MdlFuncionario();
        public string result;
        public string comando;
        public List<MdlFuncionario> funcionarios;

        public void teste()
        {

        }


        public MdlFuncionario FazerLogin(MdlFuncionario _mdlFuncionario)
        {
            string login, senha;
            login = _mdlFuncionario.GetLogin();
            senha = _mdlFuncionario.GetSenha();

            _dal.Conectar();
            funcionario = _dal.FazerLogin(_mdlFuncionario);

            return funcionario;
        }

    }
}
