using System;
class HelloWorld {
  static void Main() {
      
      int escolha;
    Console.WriteLine("Escolha um personagem:");
    Console.WriteLine("1- Guerreira");
    Console.WriteLine("2- Mago");
    Console.WriteLine("3- Arqueira");
    escolha = Convert.ToInt32(Console.ReadLine());
    
    switch(escolha){
        case 1:
        Console.WriteLine("O poder do personagem é: \n Ataque Pesado e Defesa Total");
        break;
        
        case 2:
        Console.WriteLine("O poder do personagem é: \n Bola de Fogo e Escudo de Gelo");
        break;
        
        case 3:
        Console.WriteLine("O poder do personagem é: \n Flecha Precisa e Disparo Triplo");
        break;
        
        default:
        Console.WriteLine("Esta opcao não existe");
        break;
    }
  }
}