#include <iostream>
using namespace std;

int num;
    int invertido (int numero){
        int numero_reverso = 0;
        
        while (numero > 0){
            int ultimoDigitado = numero % 10;
            numero_reverso = ultimoDigitado + numero_reverso * 10;
            numero = numero / 10;
        }
        return numero_reverso;
    }

int main()
{
    cout << "Digite um número inteiro" << endl;
    cin >> num;
    int numRevertido = invertido(num);
    cout << "O reverso do número digitado é: \n" << numRevertido << endl;

    return 0;
}