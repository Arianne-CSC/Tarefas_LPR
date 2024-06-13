/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <array>
#include <iostream>
using namespace std;

int main() {
  array<int, 10> numero;
  int qtd_par = 0;
  int qtd_impar = 0;
  array<int, 10> vetor_par;
  array<int, 10> vetor_impar;
  
  for (int i = 0; i < 10; i++) {
    cout << "Insira um valor " << i+1 <<"/10:" <<endl;
    cin >> numero[i];
    if (numero[i] % 2 == 0) {
      vetor_par[qtd_par] = numero[i];
      qtd_par++;
    } else {
      vetor_impar[qtd_impar] = numero[i];
      qtd_impar++;
    }
  }
  
  cout << "Par: ";
  for(int i=0;i<qtd_par;i++){
    cout << vetor_par[i] << " ";
  }
  cout << "Impar: ";
  for(int i=0;i<qtd_impar;i++){
    cout << vetor_impar[i] << " ";
  }
}