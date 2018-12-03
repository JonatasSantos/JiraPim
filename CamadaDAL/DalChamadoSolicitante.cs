using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using CamadaEntidades;

namespace CamadaDAL
{
    public class DalChamadoSolicitante
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["db_JIRAPIM"].ConnectionString;
        public SqlConnection sql;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataTable dataTable;
        public SqlCommandBuilder commandBuilder;
        public string comando, erroMsg = "Ocorreu um erro ao acessar a Base de Dados: ";

        public void Conectar()
        {
            if (sql != null)//if(sql.State == ConnectionState.Open)
            {
                sql.Close();
            }
            sql = new SqlConnection(connectionString);
            sql.Open();
        }
        
        public bool abrirChamado(MdlChamado _mdlChamado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("PROC_ABRIR_CHAMADO", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new[] {
                        new SqlParameter("@NOME_CHAMADO", _mdlChamado.GetTitulo()),
                        new SqlParameter("@ID_NIVEL_CHAMADO", _mdlChamado.GetCategoria()),
                        new SqlParameter("@DESCRICAO", _mdlChamado.GetDescricao()),
                        new SqlParameter("@ID_STATUS_CHAMADO", 1)
                    });
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(erroMsg + e.Message);
            }
        }

        public MdlChamado getChamado(MdlChamado _mdlChamado)
        {
            comando = "PROC_BUSCA_CHAMADO";
            MdlChamado chamado = new MdlChamado();

            using(SqlCommand cmd = new SqlCommand(comando, sql))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID_CHAMADO", _mdlChamado.GetCodigo());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chamado.SetTitulo(reader["NOME_CHAMADO"].ToString());
                    chamado.SetCategoria(Convert.ToInt32(reader["ID_NIVEL_CHAMADO"]));
                    chamado.SetDescricao(reader["DESCRICAO"].ToString());
                }
            }
            return chamado;
        }

        
    }
}
