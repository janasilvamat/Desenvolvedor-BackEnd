
using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class Funcionario

    {
        //Campos
        private string nome;
        private List<HoraContrato> contratos;


        protected List<HoraContrato> Contratos
        {
            get { return contratos; }
            set { contratos = value; }
        }

        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        //Construtor
        public Funcionario(string nome)
        {
            Contratos = new List<HoraContrato>();
            Nome = nome;
        }
        //Métodos
        public void AdicionarContrato(double valor, int horas)
		{
		    HoraContrato contrato = new HoraContrato(valor, horas);
            Contratos.Add(contrato);
        }
    }
}


