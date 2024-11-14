using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula12
{
    internal class Turma
    {
        public string nome { get; set; }
        public List<Matricula> Matriculas { get; set; }

        public Turma(string nome)
        {
            this.nome = nome;
            Matriculas = new List<Matricula>();

            public void Adicionarmatricula(Matricula matriatual)
            {
                foreach (Matricula matricula in Matriculas)
                {
                    if (matriculatual.Aluno == matricula.aluno)
                    {
                        Console.WriteLine("Aluno já está matriculado");
                        return;
                    }
                }
                Matriculas.Add(matriatual);
                Console.WriteLine("Matricula realizada");
            }
            public void mostrarAlunos()
            {
                Console.WriteLine("Alunos cadastrados: ");
                foreach (Matricula matricula in Matriculas)
                {
                    Console.WriteLine(matricula.aluno.nome);
                }
            }
        }
    }
}
