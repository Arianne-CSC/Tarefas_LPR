using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula12
{
    internal class Aluno
    {
        public string nome { get; set; }
        public List<Matricula> Matriculas {  get; set; }

        public Aluno(string nome)
        {
            this.nome = nome;
            Matriculas = new List<Matricula>();
        }
        public void Adicionarmatricula(Matricula matricula)
        {
            foreach (var matriatual in Matriculas)
            {
                if(matriatual.turma == matricula.turma)
                {
                    Console.WriteLine($"Já matriculado em {matriatual}");
                    return;
                }
                else
                {
                    Matriculas.Add(matriatual);
                    Console.WriteLine("Matricula realizada");
                }
            }

        }
    }
    
}
