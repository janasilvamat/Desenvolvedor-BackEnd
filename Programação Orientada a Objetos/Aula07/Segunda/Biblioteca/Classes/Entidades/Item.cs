
using Biblioteca.Interfaces;

namespace Biblioteca.Classes.Entidades
{
    internal class Item : IMovimentacao, IInformacoes
    {
        //Campos
        private string titulo;
        private DateTime ano;
        private int quantidade;


        //Propriedades
        protected string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        protected DateTime AnoPublicacao
        {
            get { return ano; }
            set { ano = value; }
        }

        protected int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        //Construtor
        public Item(string titulo, DateTime anoPublicacao)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Quantidade = 0;
        }

        public Item(string titulo, DateTime anoPublicacao, int quantidade) : this(titulo, anoPublicacao)
        {
            Quantidade = quantidade;
        }

        //Metodos
        public void Devolver(int quantia)
        {
            Quantidade += quantia;
        }

        public void Emprestar(int quantia)
        {
            Quantidade -= quantia;
        }

        public virtual string Exibir()
        {
            return ($"Dados do Item: \n" + 
            $"\tTítulo: {Titulo}\n" +
            $"\tAno de publicação: {AnoPublicacao}\n" + 
            $"\tQuantidade Disponível> {Quantidade}\n");

        }

    }
}
