using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Reserva
    {
        public int Id { get; }
        Cliente cliente;
        static int cont = 1;

        public Reserva (Cliente cliente)
        {
            this.cliente = cliente;
            this.Id = cont;
            cont++;
        }
    }
}
