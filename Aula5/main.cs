using System;
class HelloWorld {
  static void Main() {
      
    int A, B;
    Console.WriteLine("Digite um número inteiro");
    A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite um número inteiro");
    B = Convert.ToInt32(Console.ReadLine());
    
    if (A % B == 0){
        Console.WriteLine("Os números são múltiplos");
    }
    else if (B % A == 0){
        Console.WriteLine("Os números são múltiplos");
    }
    else{
        Console.WriteLine("Os números NÃO são multiplos");
    }
  }
}