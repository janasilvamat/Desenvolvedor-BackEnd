
namespace Triangulo_Com_POO
{
    internal class Triangulo
    {
        //Membros
        //1º Membro -> Campos
        public double a, b, c;

        //2º Membro -> Métodos
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
