/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(string[] args)
    {
        int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        int[,] resultado = new int[3, 3];

        for (int i = 0; i < 3; i++){
          for (int j = 0; j < 3; j++){
              Console.WriteLine($"Entre com um valor para a matriz 'a' na posição[{i},{j}]: ");
              a[i, j] = Convert.ToInt32(Console.ReadLine());
          }
        }
        for (int i = 0; i < 3; i++){
          for (int j = 0; j < 3; j++)
          {
              Console.WriteLine($"Entre com um valor para a matriz 'b' na posição[{i},{j}]: ");
              b[i, j] = Convert.ToInt32(Console.ReadLine());
          }
        }

        for (int i = 0; i < 3; i++){
          for (int j = 0; j < 3; j++){
            resultado[i, j] = 0;
            for (int k = 0; k < 3; k++){
                resultado[i, j] += a[i, k] * b[k, j];
            }
          }
        }
      Console.WriteLine("Resultado: ");
      for (int i = 0; i < 3; i++){
        for (int j = 0; j < 3; j++){
          Console.WriteLine($"[{i},{j}]: {resultado[i, j]}");
        }
      }
    }
}