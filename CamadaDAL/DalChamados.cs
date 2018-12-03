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
    public class DalChamados
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["db_JIRAPIM"].ConnectionString;
        public SqlConnection sql;
        public SqlDataAdapter adapter;
        public DataTable chamados = new DataTable();
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

        public DataTable retChamados()
        {
            comando = "SELECT [Número], [Título], [Prioridade], [Data Abertura], [Situação] FROM VW_CHAMADOS";
            adapter = new SqlDataAdapter(comando, sql);
            adapter.Fill(chamados);
            return chamados;
        }

        public DataTable pesquisarChamados(MdlChamado mdlChamado)
        {
            chamados.Rows.Clear();
            comando = "EXEC PROC_PESQUISAR_CHAMADO '" + mdlChamado.GetCodigo() + "', " + mdlChamado.GetStatus() + ", "
                + mdlChamado.GetDataHoraAbertura() + ", " + mdlChamado.GetCategoria() + ", " + mdlChamado.GetTitulo();

            adapter = new SqlDataAdapter(comando, sql);
            adapter.Fill(chamados);
            
            return chamados;
        }

    }
}