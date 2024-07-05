using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    int x;
    Console.WriteLine("Insira a quantidade de nomes a serem digitados: ");
    x = Convert.ToInt32(Console.ReadLine());
    List<string> nomes = new List<string>();
    List<int> tamanho = new List<int>();
    
    for(int i = 0; i < x; i++){
        string nome = Console.ReadLine();
        nomes.Add(nome);
        tamanho.Add(nome.Length);
    }
    
    
    for(int i = 0; i < x; i++){
        
    }
    
  }
 
}