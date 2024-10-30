using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula11
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public double nota1;
        public double nota2;
        public double nota_trabalho;

        public Aluno (string nomeAluno, int matriculaAluno, double nota1Aluno, double nota2Aluno, double nota_trabalhoAluno)
        {
            nome = nomeAluno;
            matricula = matriculaAluno;
            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            nota_trabalho = nota_trabalhoAluno;
        }

        public double Media()
        {
            double mediaFinal = (((nota1 * 2.5) + (nota2 * 2.5) + (nota_trabalho * 2)) / 7);
            return mediaFinal;
        }

        public double notaFinal()
        {
            double mediaAtual = Media();

            if(mediaAtual >= 7)
            {
                return 0;
            }
            else
            {
                double notaNecessaria = 7 - mediaAtual;
                return notaNecessaria;
            }
        }
    }
}
