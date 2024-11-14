using Exercicio2_Aula12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula12
{
    internal class Program
    {
        static void Main()
        {
            string titulo;
            string autor;
            int anopubli;

            Console.WriteLine("Digite o título de um livro: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor do livro: ");
            autor = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação do livro: ");
            anopubli = Convert.ToInt32(Console.ReadLine());
            
            Livro l1=new Livro (titulo, autor, anopubli);//obj l1
            Console.WriteLine($"Foi adicionado o livro com os seguintes dados: Titulo: {l1.titulo}, Autor: {l1.autor}, Publicação: {l1.anopubli}");
            Livro l2 = new Livro("Ana Terra", "Érico Veríssimo", 1949);//teste,se não funcionar eu comento


            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivro (l1);
            biblioteca.AdicionarLivro (l2);
            biblioteca.ListarLivros();

            Console.ReadLine();
        }
    }
}