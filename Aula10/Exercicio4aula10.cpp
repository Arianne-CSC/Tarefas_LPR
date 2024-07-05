#include <iostream>
#include <string>
#include <vector>
#include <map>
using namespace std;

int main() {
    int x;
    int y;
    int soma = 0;
    double media;
    string maiorcidade = "";
    string menorcidade = "";
    int max = 0;
    int min = 100000000;
    cout << "Insira a quantidade de cidades a serem digitadas: " << endl;
    cin >> x;
    map<string, int> cidades;

    for (int i = 0; i < x; i++) {
        string nome;
        int populacao;
        cout << "Digite o nome da cidade: "<< endl;
        cin >> nome;
        cout << "Digite a população: "<< endl;
        cin >> populacao;
        cidades[nome] = populacao;
        soma = soma + populacao;
    }
    media = soma / x;
    cout << "Cidades acima da média de população:" << endl;
    for (const auto& cidade : cidades) {
        if (cidade.second > media) {
            cout << cidade.first << endl;
        }
    }

    for (const auto& cidade : cidades) {
        if (cidade.second > max) {
            max = cidade.second;
            maiorcidade = cidade.first;
        }
        if (cidade.second < min) {
            min = cidade.second;
            menorcidade = cidade.first;
        }
    }
    cout << "Cidade com maior população: " << maiorcidade << endl;
    cout << "Cidade com menor população: " << menorcidade << endl;

    cout << "Insira um valor de corte: ";
    cin >> y;
    vector<string> selecionadas;
    for (const auto& cidade : cidades) {
        if (cidade.second == y) {
            selecionadas.push_back(cidade.first);
        }
    }
    for (const auto& nome : selecionadas) {
        cidades.erase(nome);
    }
    cout << "Cidades diferentes da população " << y << ":" << endl;
    for (const auto& cidade : cidades) {
        cout << cidade.first << endl;
    }

    return 0;
}
