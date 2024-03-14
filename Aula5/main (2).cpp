#include <iostream>
using namespace std;

int main()
{
    int num;
    cout << "Digite um número inteiro" << endl;
    cin >> num;
    
    if(num % 2 == 0){
        cout << "O número que foi digitado é par" << endl;
        
    }
    else{
        cout << "O número que foi digitado é ímpar" << endl;
    }

    return 0;
}
