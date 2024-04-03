using System;
class Program {
  static void Main() {
      
      int num_palpite;
      int valorInteiro;
      int contador = 0;
      
    Random num_aleatorio = new Random();
    valorInteiro = num_aleatorio.Next (1,100);
    
    do{
        Console.WriteLine("Tente adivinhar um número de 1 a 100");
        num_palpite = Convert.ToInt32(Console.ReadLine());
        contador++;
        
        if (num_palpite < valorInteiro){
            Console.WriteLine("Chutou baixo!");
        }
        else if(num_palpite > valorInteiro){
            Console.WriteLine("Chutou alto!");
        }
        else{
            Console.WriteLine($"ACERTOU!! O número é {valorInteiro}");
            Console.WriteLine($"Suas tentativas foram: {contador}");
        }
        
    } while(contador != valorInteiro);
  }
}