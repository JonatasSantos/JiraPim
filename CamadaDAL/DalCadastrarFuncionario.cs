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
    public class DalCadastrarFuncionario
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

        public bool ExecutarComando(string comando)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(comando, sql);
                cmd.ExecuteNonQuery();
                return true;
            } catch(Exception e)
            {
                throw new Exception(erroMsg + e.Message);
            }
            
        }

        public bool Incluir(MdlFuncionario mdlFuncionario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("PROC_INCLUIR_CADASTRO", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new[] {
                        new SqlParameter("@NOME_FUNCIONARIO", mdlFuncionario.GetNome()),
                        new SqlParameter("@NUM_CPF", mdlFuncionario.GetCPF()),
                        new SqlParameter("@NUM_RG", mdlFuncionario.GetRG()),
                        new SqlParameter("@DATA_NASCIMENTO", mdlFuncionario.GetDataNascimento()),
                        new SqlParameter("@DATA_ADMISSAO", mdlFuncionario.GetDataAdmissao()),
                        new SqlParameter("@TELEFONE1", mdlFuncionario.GetTel1()),
                        new SqlParameter("@TELEFONE2", mdlFuncionario.GetTel2()),
                        new SqlParameter("@CELULAR", mdlFuncionario.GetCelular()),
                        new SqlParameter("@EMAIL_FUNC", mdlFuncionario.GetEmail()),
                        new SqlParameter("@CEP", mdlFuncionario.GetCEP()),
                        new SqlParameter("@LOGRADOURO", mdlFuncionario.GetEndereco()),
                        new SqlParameter("@NUMERO", mdlFuncionario.GetNumero()),
                        new SqlParameter("@COMPLEMENTO", mdlFuncionario.GetComplemento()),
                        new SqlParameter("@BAIRRO", mdlFuncionario.GetBairro()),
                        new SqlParameter("@CIDADE", mdlFuncionario.GetCidade()),
                        new SqlParameter("@UF", mdlFuncionario.GetUf()),
                        new SqlParameter("@PAIS", mdlFuncionario.GetPais()),
                        new SqlParameter("@ID_CARGO", mdlFuncionario.GetCargo()),
                        new SqlParameter("@ID_PERFIL_USUARIO", mdlFuncionario.GetTipo()),
                        new SqlParameter("@LOGIN", mdlFuncionario.GetLogin()),
                        new SqlParameter("@SENHA", mdlFuncionario.GetSenha())
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

        public MdlFuncionario getFuncionario(MdlFuncionario _mdlFuncionario)
        {
            comando = "PROC_BUSCA_FUNCIONARIO";
            MdlFuncionario funcionario = new MdlFuncionario();

            using(SqlCommand cmd = new SqlCommand(comando, sql))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID_FUNCIONARIO", _mdlFuncionario.GetId());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    funcionario.SetId(Convert.ToInt32(reader["ID_FUNCIONARIO"]));
                    funcionario.SetNome(reader["NOME_FUNCIONARIO"].ToString());
                    funcionario.SetCPF(reader["CPF_FUNCIONARIO"].ToString());
                    funcionario.SetRG(reader["RG_FUNCIONARIO"].ToString());
                    funcionario.SetDataNascimento(Convert.ToDateTime(reader["DATA_NASCIMENTO"]));
                    funcionario.SetDataAdmissao(Convert.ToDateTime(reader["DATA_ADMISSAO"].ToString()));
                    funcionario.SetTel1(reader["TELEFONE1"].ToString());
                    funcionario.SetTel2(reader["TELEFONE2"].ToString());
                    funcionario.SetCelular(reader["CELULAR"].ToString());
                    funcionario.SetEmail(reader["EMAIL_FUNCIONARIO"].ToString());
                    funcionario.SetCEP(reader["CEP"].ToString());
                    funcionario.SetEndereco(reader["LOGRADOURO"].ToString());
                    funcionario.SetNumero(Convert.ToInt32(reader["NUMERO"].ToString()));
                    funcionario.SetComplemento(reader["COMPLEMENTO"].ToString());
                    funcionario.SetBairro(reader["BAIRRO"].ToString());
                    funcionario.SetCidade(reader["CIDADE"].ToString());
                    funcionario.SetUf(reader["UF"].ToString());
                    funcionario.SetPais(reader["PAIS"].ToString());
                    funcionario.SetCargo(Convert.ToInt32(reader["ID_CARGO"].ToString()));
                    funcionario.SetTipo(Convert.ToInt32(reader["ID_PERFIL_USUARIO"].ToString()));
                    funcionario.SetLogin(reader["LOGIN"].ToString());
                    funcionario.SetSenha(reader["SENHA"].ToString());
                    //funcionario.SetNome(reader["ID_DEPARTAMENTO"].ToString());
                }
            }
            return funcionario;
        }
        
    }
}
