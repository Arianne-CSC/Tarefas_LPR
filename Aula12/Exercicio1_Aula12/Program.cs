using Exercicio1_Aula12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente("Arianne");

            Reserva r1 = new Reserva(cliente);
            Console.WriteLine(r1.Id);
            Reserva r2 = new Reserva(cliente);
            Console.WriteLine(r2.Id);

            Console.ReadLine();
        }
    }
}
