using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula12
{
    internal class Matricula
    {
        public string data {  get; set; }
        public Aluno aluno { get; set; }
        public Turma turma { get; set; }

        public Matricula(string data, Aluno aluno, Turma turma)
        {
            this.data = data;
            this.aluno = aluno;
            this.turma = turma;
        } 
    }
}
