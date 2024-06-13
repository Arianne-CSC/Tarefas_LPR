/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
        int[,] distancias = new int[4, 4];
        distancias[0, 0] = 0;
        distancias[1, 1] = 0;
        distancias[2, 2] = 0;
        distancias[3, 3] = 0;
        distancias[0, 1] = 524;
        distancias[1, 0] = 524;
        distancias[0, 2] = 521;
        distancias[2, 0] = 521;
        distancias[0, 3] = 882;
        distancias[3, 0] = 882;
        distancias[1, 2] = 434;
        distancias[2, 1] = 434;
        distancias[1, 3] = 586;
        distancias[3, 1] = 586;
        distancias[2, 3] = 429;
        distancias[3, 2] = 429;
        Console.WriteLine("Codigo das cidades");
        Console.WriteLine("Vitoria - 0");
        Console.WriteLine("Belo Horizonte - 1");
        Console.WriteLine("Rio de Janeiro - 2");
        Console.WriteLine("São Paulo - 3"); 
        int origem = 0;
        int destino = -1;
        while (destino != origem)
        {
            Console.WriteLine("Digite o codigo da cidade de origem:");
            origem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o codigo da cidade de destino:");
            destino = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A distancia entre as cidades é {distancias[origem, destino]}Km");
        }
    }
}