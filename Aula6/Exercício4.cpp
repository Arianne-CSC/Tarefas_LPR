#include <iostream>
using namespace std;

int main()
{
    int num;
    int quadrado;
    int soma = 0;
    
    cout<<"Digite um número:" << endl;
    cin>> num;
    quadrado = num * num;
    
    while(quadrado>0){
        soma = soma + (quadrado%10);
        quadrado = quadrado/10;
    }
    cout<< "A soma do quadrado do número é " <<soma << endl;

    return 0;
}