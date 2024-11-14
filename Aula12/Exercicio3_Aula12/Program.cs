using Exercicio3_Aula12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Maria");
            Aluno aluno2 = new Aluno("João");
            Aluno aluno3 = new Aluno("Joana");
            Turma t1 = new Turma("01");

            Matricula m1 = new Matricula("01/01/2001", aluno1, t1);
            Matricula m2 = new Matricula("02/02/2002", aluno2, t1);
            Matricula m3 = new Matricula("03/03/2003", aluno3, t1);

            aluno1.Adicionarmatricula(m1);
            aluno1.Adicionarmatricula(m2);
            aluno2.Adicionarmatricula(m3);

            t1.Adicionarmatricula(m1);
            t1.Adicionarmatricula(m2);
            t1.Adicionarmatricula(m3);

            t1.mostrarAlunos();

        }
    }
}

