using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula11
{
    public class Funcionario
    {
        public string nome;
        public double salario_bruto;
        public double imposto;

        public Funcionario (string nomeFuncionario, double salario_brutoFuncionario)
        {
            nome = nomeFuncionario;
            salario_bruto = salario_brutoFuncionario;
            imposto = CalcImposto(salario_bruto);
        }

        public double CalcImposto(double salario)
        {
            if (salario <= 2000)
            {
                return salario * (10 / 100);
            }
            else if (salario <= 3000)
            {
                return salario * (15 / 100);
            }
            else
            {
                return salario * (20 / 100);
            }

        }

        public double CalcLiquid()
        {
            return salario_bruto - imposto;
        }

        public void Dados()
        {
            Console.WriteLine($"Nome do funcionário: {nome}");
            Console.WriteLine($"Salário do funcionário: {CalcLiquid()}");
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento;
            aumento = salario_bruto * (porcentagem /100);
            salario_bruto = salario_bruto + aumento;
            imposto = CalcImposto(salario_bruto);
        }
    }
}
