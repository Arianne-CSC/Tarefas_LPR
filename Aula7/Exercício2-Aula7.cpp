#include <iostream>
using namespace std;

double Exercicio_1(int quantidade)
{
    int contador = 0;
    int soma = 0;
    
    while (quantidade > 0){
        int numero;
        cout << "Digite um número inteiro: ";
        cin >> numero;
        
        if (numero % 2 == 0){
            soma = soma + numero;
            contador ++;
        }
        quantidade--;
    }
    
    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        return media;
    } 
    else {
        cout << "Nenhum número par foi digitado." << endl;
        return 0;
    }
}

int Exercicio_3(int começo, int final, int divis)
  {
    int soma = 0;
    
    for (int i = começo; i <= final; i++) {
        if (i % 2 != 0 && i % divis == 0) {
            soma = soma + i; 
        }
    }
    return soma;
  }

int Exercicio_4(int num) 
{
    int quadrado;
    int soma = 0;
    
    quadrado = num * num;
    
    while(quadrado>0){
        soma = soma + (quadrado%10);
        quadrado = quadrado/10;
    }
    return soma;
}

int main()
{
    int escolha;
    cout << "Escolha qual exercício deseja visualizar. Digite o número correspondente ao exercício" << endl;
    cout << "1- Exercício 1" << endl;
    cout << "3- Exercício 3" << endl;
    cout << "4- Exercício 4" << endl;
    cin >> escolha;
    
    int quant;
    double med;
    
    int inicio, fim, divisor;
    int somatoria;
    
    int numero;
    int soma;
    
     switch(escolha){
        case 1:
        cout << "Digite a quantidade de números que serão inseridos: ";
        cin >> quant;
        med = Exercicio_1(quant);
        cout << "A média dos números pares é: " << med << endl;
        break;
        
        case 3:
        cout << "Digite o valor inicial do conjunto: " << endl;
        cin >> inicio;
        cout << "Digite o valor final do conjunto: " << endl;
        cin >> fim;
        cout << "Digite o divisor: " << endl;
        cin >> divisor;
        somatoria = Exercicio_3(inicio,fim,divisor);
        cout << "A soma dos números ímpares múltiplos de " << divisor << " de " << inicio << " a " << fim <<" é: " << somatoria << endl;
        break;
        
        case 4:
        cout << "Digite um número: " << endl;
        cin >> numero;
        soma = Exercicio_4(numero);
        cout << "A soma dos dígitos do quadrado de " << numero << " é: " << soma << endl;
        break;
        
        default:
        cout << "Essa opção não é possível!!" << endl;
        break;
    }
    return 0;
}
