#include <iostream>
using namespace std;

int main()
{
    int num_hrs_diaria;
    int dias_treina = 0;
    int semanas_treina = 0;
    int total_hrs = 0;
    int total_hrs_semanal;
    double meses_treina = 0;
    
    cout<<"Insira as horas de treinamento por dia: ";
    cin>>num_hrs_diaria;
    
    while(total_hrs < 1000){
        total_hrs_semanal = 5 * num_hrs_diaria;
        total_hrs = total_hrs + total_hrs_semanal;
        dias_treina = 1000 / num_hrs_diaria;
        semanas_treina = dias_treina / 5;
        meses_treina = semanas_treina / 4.5;
    }
    cout<<"Quantidade de dias necessários para alcançar as 1000 horas de treinamento: " << dias_treina << endl;
    cout<<"Quantidade de semanas necessários para alcançar as 1000 horas de treinamento: " << semanas_treina << endl;
    cout<<"Quantidade de meses necessários para alcançar as 1000 horas de treinamento: " << meses_treina << endl;

    return 0;
}