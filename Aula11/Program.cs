using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto do funcionário: ");
            double salario_bruto = Convert.ToDouble(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salario_bruto);

            funcionario.Dados();

            Console.WriteLine("Digite a porcentagem em que será aumentado o salário: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados do funcionário atualizados: ");
            funcionario.Dados();

            Console.ReadLine();
        }
    }
}
    