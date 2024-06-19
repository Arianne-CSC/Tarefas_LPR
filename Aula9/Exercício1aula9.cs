using System;
class HelloWorld {
    
    public struct Produto{
          public string Nome;
          public int Codigo;
          public double Preco;
          public int Quantidade;
    }

  static void Main() {
     Produto[] array1 = new Produto[3];
     double total = 0;
    int i;
    for (i = 0; i < 3; i ++){
    Console.WriteLine("Digite o nome do produto: ");
    array1[i].Nome = Console.ReadLine();
    Console.WriteLine("Digite o código do produto: ");
    array1[i].Codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o preço do produto: ");
    array1[i].Preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade do produto: ");
    array1[i].Quantidade = Convert.ToInt32(Console.ReadLine());
    
    }
    total = ((array1[0].Preco * array1[0].Quantidade) + (array1[1].Preco * array1[1].Quantidade) + (array1[2].Preco * array1[2].Quantidade));
    Console.WriteLine($"O valor total dos produtos foi de: {total}");
        
  }
}