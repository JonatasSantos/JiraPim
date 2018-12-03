using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CamadaEntidades;

namespace CamadaDAL
{
    public class DalLogin
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["db_JIRAPIM"].ConnectionString;
        public SqlConnection sql;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataTable dataTable;
        public string erroMsg = "Ocorreu um erro ao acessar a Base de Dados: ";
        public List<MdlFuncionario> mdlFuncionario = new List<MdlFuncionario>();
        public string comando;

        public void Conectar()
        {
            if (sql != null)//if(sql.State == ConnectionState.Open)
            {
                sql.Close();
            }
            sql = new SqlConnection(connectionString);
            sql.Open();
        }

        public MdlFuncionario FazerLogin(MdlFuncionario funcionario)
        {
            comando = "SELECT ID_FUNCIONARIO, LOGIN, SENHA, ID_PERFIL_USUARIO FROM FUNCIONARIO WHERE LOGIN LIKE '" + funcionario.GetLogin() + "' " +
                "AND SENHA = '" + funcionario.GetSenha() + "'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(comando, sql))
                {
                    cmd.CommandType = CommandType.Text;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                funcionario.SetId(reader.GetInt32(reader.GetOrdinal("ID_FUNCIONARIO")));
                                funcionario.SetLogin(reader.GetString(reader.GetOrdinal("LOGIN")));
                                funcionario.SetSenha(reader.GetString(reader.GetOrdinal("SENHA")));
                                funcionario.SetTipo(reader.GetInt32(reader.GetOrdinal("ID_PERFIL_USUARIO")));
                                mdlFuncionario.Add(funcionario);
                            }
                        } else
                        {
                            funcionario.SetId(0);
                        }
                    }
                }
                return funcionario;
            } catch (Exception e)
            {
                throw new Exception("Um erro ocorreu: " + e.Message);
            }
        }
    }
}
