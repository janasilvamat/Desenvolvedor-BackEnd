
namespace Biblioteca.Classes.Entidades
{
    internal class Manga : Item
    {
        //Campos
        private int numero;
        private string mes;

        //Propriedades
        protected int NumeroDoManga
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string MesDePublicacao
        {
            get { return mes; }
            set { mes = value; }
        }

        //Construtores
        public Manga(string titulo, DateTime anoPublicacao, int numero, string mes) : base(titulo, anoPublicacao)
        {
            NumeroDoManga = numero;
            MesDePublicacao = mes;
        }

        public Manga(string titulo, DateTime anoPublicacao, int quantidade, int numero, string mes) : base(titulo, anoPublicacao, quantidade)
        {
            NumeroDoManga = numero;
            MesDePublicacao = mes;
        }

        //Metodos
        public override string Exibir()
        {
            return base.Exibir() + $"\tNúmero do manga: {NumeroDoManga}\n" + $"\tMês de publicação: {MesDePublicacao}\n";
        }
    }
}
