using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CamadaEntidades
{
    public class MdlFuncionario
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        private string nome;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        private string rG;

        public string GetRG()
        {
            return rG;
        }

        public void SetRG(string value)
        {
            rG = value;
        }

        private DateTime dataNascimento;

        public DateTime GetDataNascimento()
        {
            return dataNascimento;
        }

        public void SetDataNascimento(DateTime value)
        {
            dataNascimento = value;
        }

        private DateTime dataAdmissao;

        public DateTime GetDataAdmissao()
        {
            return dataAdmissao;
        }

        public void SetDataAdmissao(DateTime value)
        {
            dataAdmissao = value;
        }

        private string celular;

        public string GetCelular()
        {
            return celular;
        }

        public void SetCelular(string value)
        {
            celular = value;
        }

        private string tel1;

        public string GetTel1()
        {
            return tel1;
        }

        public void SetTel1(string value)
        {
            tel1 = value;
        }

        private string tel2;

        public string GetTel2()
        {
            return tel2;
        }

        public void SetTel2(string value)
        {
            tel2 = value;
        }

        private string email;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        private string endereco;

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string value)
        {
            endereco = value;
        }

        private int numero;

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int value)
        {
            numero = value;
        }

        private string complemento;

        public string GetComplemento()
        {
            return complemento;
        }

        public void SetComplemento(string value)
        {
            complemento = value;
        }

        private string cEP;

        public string GetCEP()
        {
            return cEP;
        }

        public void SetCEP(string value)
        {
            cEP = value;
        }

        private string bairro;

        public string GetBairro()
        {
            return bairro;
        }

        public void SetBairro(string value)
        {
            bairro = value;
        }

        private string cidade;

        public string GetCidade()
        {
            return cidade;
        }

        public void SetCidade(string value)
        {
            cidade = value;
        }

        private string uf;

        public string GetUf()
        {
            return uf;
        }

        public void SetUf(string value)
        {
            uf = value;
        }

        private string pais;

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string value)
        {
            pais = value;
        }

        private string cPF;

        public string GetCPF()
        {
            return cPF;
        }

        public void SetCPF(string value)
        {
            cPF = value;
        }

        private int cargo;

        public int GetCargo()
        {
            return cargo;
        }

        public void SetCargo(int value)
        {
            cargo = value;
        }

        private int departamento;

        public int GetDepartamento()
        {
            return departamento;
        }

        public void SetDepartamento(int value)
        {
            departamento = value;
        }

        private int tipo;

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int value)
        {
            tipo = value;
        }

        private string login;

        public string GetLogin()
        {
            return login;
        }

        public void SetLogin(string value)
        {
            login = value;
        }

        private string senha;

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string value)
        {
            senha = value;
        }

        private int status;

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int value)
        {
            status = value;
        }
    }
}
