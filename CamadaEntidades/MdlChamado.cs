using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidades
{
    public class MdlChamado
    {
        private int codigo;

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int value)
        {
            codigo = value;
        }

        private string titulo;

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string value)
        {
            titulo = value;
        }

        private int categoria;

        public int GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(int value)
        {
            categoria = value;
        }

        private string descricao;

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string value)
        {
            descricao = value;
        }

        private string tipo;

        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string value)
        {
            tipo = value;
        }

        private DateTime dataHoraAbertura;

        public DateTime GetDataHoraAbertura()
        {
            return dataHoraAbertura;
        }

        public void SetDataHoraAbertura(DateTime value)
        {
            dataHoraAbertura = value;
        }

        private DateTime dataHoraFechamento;

        public DateTime GetDataHoraFechamento()
        {
            return dataHoraFechamento;
        }

        public void SetDataHoraFechamento(DateTime value)
        {
            dataHoraFechamento = value;
        }

        private string comentarioSolucao;

        public string GetComentarioSolucao()
        {
            return comentarioSolucao;
        }

        public void SetComentarioSolucao(string value)
        {
            comentarioSolucao = value;
        }

        private string feedback;

        public string GetFeedback()
        {
            return feedback;
        }

        public void SetFeedback(string value)
        {
            feedback = value;
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
