using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CamadaEntidades;
using System.Collections.ObjectModel;

namespace CamadaDAL
{
    public class DalFuncionarios
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["db_JIRAPIM"].ConnectionString;
        public SqlConnection sql;
        public SqlDataAdapter adapter;
        public DataTable funcionarios = new DataTable();
        public string erroMsg = "Ocorreu um erro ao acessar a Base de Dados: ";
        public string comando;

        public void Conectar()
        {
            if (sql != null)
            {
                sql.Close();
            }
            sql = new SqlConnection(connectionString);
            sql.Open();
        }

        public DataTable retFuncionarios()
        {
            comando = "SELECT [Código], [Funcionário], [Tipo], [Cargo], [Departamento], [Status] FROM VW_FUNCIONARIOS";
            adapter = new SqlDataAdapter(comando, sql);
            adapter.Fill(funcionarios);
            return funcionarios;
        }

        public DataTable pesquisarFuncionarios(MdlFuncionario mdlFuncionario)
        {
            funcionarios.Rows.Clear();
            comando = "EXEC PROC_PESQUISAR_FUNCIONARIO '" + mdlFuncionario.GetNome() + "', " + mdlFuncionario.GetCargo() + ", "
                + mdlFuncionario.GetDepartamento() + ", " + mdlFuncionario.GetStatus();

            adapter = new SqlDataAdapter(comando, sql);
            adapter.Fill(funcionarios);
            
            return funcionarios;
        }

    }
}