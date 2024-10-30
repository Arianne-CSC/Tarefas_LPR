using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota de prova do aluno: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota de prova do aluno: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite uma nota de trabalho do aluno: ");
            double nota_trabalho = Convert.ToDouble(Console.ReadLine());

            Aluno aluno = new Aluno(nome, matricula, nota1, nota2, nota_trabalho);

            Console.WriteLine($"A média do aluno foi: {aluno.Media():F2}");

            double notaFinal = aluno.notaFinal();
            if (notaFinal > 0)
            {
                Console.WriteLine($"O aluno precisa de {notaFinal} pontos para passar");
            }
            else
            {
                Console.WriteLine("O aluno já passou e não precisa de prova final!");
            }
        }
    }
}