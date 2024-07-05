#include <iostream>
#include <list>
#include <cstdlib>
using namespace std;

int main()
{
    list<int> numeros;
    for(int i = 0; i < 100; i++){
        int numero = rand() % 100;
        numeros.push_back(numero);
    }
    bool ordenado = false;
    bool troca = false;
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << " \n ________________________________________ \n";
    numeros.sort();
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << " \n ________________________________________ \n";
    for (auto it = numeros.begin(); it != numeros.end();) {
        if (*it % 2 == 0) {
            it = numeros.erase(it);
        } else {
            ++it; 
        }
    }
    for (int num : numeros) {
        cout << num << " ";
    }
    return 0;
}