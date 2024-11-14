using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula12
{
    internal class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anopubli {  get; set; }

        public Livro(string titulo, string autor, int anopubli)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anopubli = anopubli;
        }

    }
}
