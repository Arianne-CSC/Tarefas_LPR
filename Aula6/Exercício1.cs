using System;
class HelloWorld {
  static void Main() {
    
    int quant_num;
    double quant_num_par = 0;
    int num_analisados = 0;
    int soma = 0;
    int contador = 0;
    double media = 0;
    
    Console.WriteLine("Digite a quantidade de números analisados");
    quant_num = int.Parse(Console.ReadLine());
    
    while(contador < quant_num){
        Console.WriteLine("Digite o número analisado");
        num_analisados = int.Parse(Console.ReadLine());
        
        if(num_analisados %2 == 0){
            soma += num_analisados;
            quant_num_par ++;
        }
        contador++;
    }
    media = soma/quant_num_par;
    Console.WriteLine("A média dos números analisados é " + media);
  }
}