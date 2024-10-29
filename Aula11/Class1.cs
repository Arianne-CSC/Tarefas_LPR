using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula11
{
    internal class Class1
    {
        public double alturaRetangulo;
        public double larguraRetangulo;

        public Class1(double Altura, double Largura)
        {
            alturaRetangulo = Altura;
            larguraRetangulo = Largura;
        }

        public double calcArea()
        {
            return alturaRetangulo * larguraRetangulo;
        }

        public double calcPerimetro()
        {
            return (alturaRetangulo * 2) + (larguraRetangulo * 2);
        }
    }
}
