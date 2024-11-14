using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula12
{
    internal class Biblioteca
    {
        public List<Livro> livros = new List<Livro>();//NÃO confundir Livro com livro. Livro é a classe

        /*public Bibioteca()
        {
            
        }*/
        public void AdicionarLivro(Livro livro) //parametro chamado livro do tipo Livro //NÃO esquecer de colocar void
        {
            livros.Add(livro);
        }
        public void ListarLivros() //NÃO esquecer de colocar void
        {
            Console.WriteLine("Livros na Biblioteca: ");
            foreach (var livro in livros)
            {
                Console.WriteLine($"{ livro.titulo}, { livro.autor}, { livro.anopubli}" );
            }
        }

    }
    
}
