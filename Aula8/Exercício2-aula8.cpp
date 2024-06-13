#include <iostream>
#include <array>
using namespace std;

int main() {
  array<int,10> numero;
  for (int i = 0; i < 10; i++) {
    cout << "Insira um número: ";
    cin >> numero[i];
  }
  
  int num_pesquisa;
  cout << "Insira um número para pesquisar: ";
  cin >> num_pesquisa;
  array<int,10>  index; // vetor de posições
  int qnt = 0;
  
  for (int i = 0; i < 10; i++) {
    if (numero[i] == num_pesquisa) {
      index[qnt] = i;
      qnt++;
    }
  }
  
  if (qnt != 0) {
      cout << "Esta na(s) posição(ões): ";
    for (int i = 0; i < qnt; i++) {
      cout << index[i] << " ";
    }
    cout << endl;
    cout << "Ocorre " << qnt << " vez(es)";
  }
  else{
      cout << "Não existe o valor no vetor";
  }
}