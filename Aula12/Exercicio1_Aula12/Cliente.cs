using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Cliente
    {
        public string Nome { get; set;  }
        List<Reserva> reservas = new List<Reserva>();

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public void novaReserva(Reserva r)
        {
            reservas.Add(r);
        }

        public void mostrarReservas()
        {
            Console.WriteLine("Cliente " + Nome);
            foreach (Reserva r in reservas)
            {
                Console.WriteLine("Reserva " + r.Id);
            }
        }
    }
}
