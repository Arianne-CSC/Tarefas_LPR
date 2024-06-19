#include <iostream>
#include <string>
using namespace std;

struct Livro {
  string Titulo;
  string Autor;
  int AnoPublicacao;
  int NumeroPaginas;
  double Preco;
};

int main() {
  Livro a1;
  cout << "Digite o título do primeiro livro: \n";
  getline(cin, a1.Titulo);
  cout << "Digite o autor: \n";
  getline(cin, a1.Autor);
  cout << "Digite o ano de publicação: \n";
  cin >> a1.AnoPublicacao;
  cout << "Digite o número de páginas: \n";
  cin >> a1.NumeroPaginas;
  cout << "Digite o preço: \n";
  cin >> a1.Preco;

  cin.ignore();
  Livro a2;
  cout << "Digite o título do segundo livro: \n";
  getline(cin, a2.Titulo);
  cout << "Digite o autor: \n";
  getline(cin, a2.Autor);
  cout << "Digite o ano de publicação: \n";
  cin >> a2.AnoPublicacao;
  cout << "Digite o número de páginas: \n";
  cin >> a2.NumeroPaginas;
  cout << "Digite o preço: \n";
  cin >> a2.Preco;

  cin.ignore();
  Livro a3;
  cout << "Digite o título do terceiro livro: \n";
  getline(cin, a3.Titulo);
  cout << "Digite o autor: \n";
  getline(cin, a3.Autor);
  cout << "Digite o ano de publicação: \n";
  cin >> a3.AnoPublicacao;
  cout << "Digite o número de páginas: \n";
  cin >> a3.NumeroPaginas;
  cout << "Digite o preço: \n";
  cin >> a3.Preco;

  double total;
  double media;
  total = a1.Preco + a2.Preco + a3.Preco;
  media = (a1.NumeroPaginas + a2.NumeroPaginas + a3.NumeroPaginas) / 3.0;
  cout << "O preço total dos livros foi: " << total << endl;
  cout << "A média de páginas foi: " << media;
}