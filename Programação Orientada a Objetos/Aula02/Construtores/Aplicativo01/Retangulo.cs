
using System.Security.Cryptography;

namespace Aplicativo01
{
    internal class Retangulo
    {
        double largura;
        double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double CalcularArea()

        {
            double area = largura * altura;
           return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (largura + altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
            return diagonal;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Valores digitados foram \nLargura: {largura:f2}, \nAltura: {altura:f2}, \nÁrea do retângulo é: {CalcularArea():f2}, \nO perímetro do retângulo é: {CalcularPerimetro():f2}, \nA diagonal do retângulo é: {CalcularDiagonal():c}");
        }
    }
}
