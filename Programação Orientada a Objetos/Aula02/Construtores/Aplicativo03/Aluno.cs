
using System.Reflection.Metadata.Ecma335;

namespace Aplicativo03
{
    internal class Aluno
    {
        string nome;
        double nota1;
        double nota2;
        double nota3;
        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public double CalcularNotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            return CalcularNotaFinal() >= 60.0;
        }
        
        public double PontosFaltando()
        {
            if (CalcularNotaFinal() < 60.0)
            {
                double pontosFaltando = 60.0 - CalcularNotaFinal();
                Console.Write($"Reprovado, faltou {pontosFaltando:f2} pontos");
                return pontosFaltando;
            }
            else
            {
                return 0.0;
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nota final: {CalcularNotaFinal():f2} \nSituação: {(Aprovado() ? "Aprovado" : "Reprovado")}");
        }
    }
}
