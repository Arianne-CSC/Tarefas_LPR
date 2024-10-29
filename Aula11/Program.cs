using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo: ");
            double Largura = Convert.ToDouble(Console.ReadLine());

            Class1 retangulo = new Class1(Altura, Largura);

            double area = retangulo.calcArea();
            double perimetro = retangulo.calcPerimetro();

            Console.WriteLine($"A área do retângulo é: {area}");
            Console.WriteLine($"O perímetro do retângulo é: {perimetro}");

            Console.ReadLine();
        }
    }
}