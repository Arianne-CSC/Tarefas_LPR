using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    int x;
    int y;
    int soma = 0;
    double media;
    string maisvelha = "";
    string maisnova = "";
    int max = 0;
    int min = 1000;
    Console.WriteLine("Insira a quantidade de nomes a serem digitados: ");
    x = Convert.ToInt32(Console.ReadLine());
    Dictionary<string, int> pessoas = new Dictionary<string, int>();
    
    for (int i = 0; i < x; i++){
        string nome;
        Console.WriteLine("Digite um nome:");
        nome = Console.ReadLine();
        int idade;
        Console.WriteLine("Digite a idade:");
        idade = Convert.ToInt32(Console.ReadLine());
        pessoas.Add(nome,idade);
        soma = soma + idade;
    }
    
    media = soma / x;
    Console.WriteLine("Pessoas acima da media de idade:");
    foreach (var pessoa in pessoas){
        if (pessoa.Value > media){
            Console.WriteLine(pessoa.Key);
        }
    }
    foreach (var pessoa in pessoas){
        if (pessoa.Value > max){
            max = pessoa.Value;
            maisvelha = pessoa.Key;
        }
        if (pessoa.Value < min){
            min = pessoa.Value;
            maisnova = pessoa.Key;
        }
    }
    Console.WriteLine($"Pessoa mais velha: {maisvelha}");
    Console.WriteLine($"Pessoa mais nova: {maisnova}");
    
    Console.WriteLine("Insira um valor de corte: ");
    y = Convert.ToInt32(Console.ReadLine());
    List<string> selecionados = new List<string>();
    foreach (var pessoa in pessoas){
        if (pessoa.Value == y){
           selecionados.Add(pessoa.Key);
        }
    }
    for(int i = 0; i < selecionados.Count; i++){
        pessoas.Remove(selecionados[i]);
    }
    Console.WriteLine($"Pessoas diferentes da idade {y}:");
    foreach (var pessoa in pessoas){
        Console.WriteLine(pessoa.Key);
    }
}
}
