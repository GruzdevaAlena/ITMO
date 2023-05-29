﻿#include <fstream>
#include <iostream>
#include <windows.h>
#include <string>
using namespace std;

int* dynamicMas(int n) {
    int* mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        cout << "mas[" << i << "]=";
        cin >> mas[i];
    }
    return mas;
}

bool write(int* a,int N) {
    ofstream out("zachet.txt", ios::app | ios::binary);
    if (!out) {
        cout << "Файл открыть невозможно\n";
        return false;
    }
    for (int i = 0; i < 6; i++) {
        out << a[i] << "\t";
    }
    out << endl;
    out.close();


}
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    setlocale(LC_ALL, "Russian");
    int N = 0;
    cout << "Введите размер массива => " << endl;
    cin >> N;
    int* a = dynamicMas(N);
    write(a,N);
    int min = 0; // для записи минимального значения
    int buf = 0; // для обмена значениями

    for (int i = 0; i < N; i++)
    {
        min = i; // номер текущей ячейки, как ячейки с минимальным значением
        // в цикле найдем реальный номер ячейки с минимальным значением
        for (int j = i + 1; j < N; j++)
            min = (a[j] < a[min]) ? j : min;
        // перестановка этого элемента, поменяв его местами с текущим
        if (i != min)
        {
            buf = a[i];
            a[i] = a[min];
            a[min] = buf;
        }
    }
    for (int i = 0; i < N; i++)
        cout << a[i] << '\t';
    write(a,N);
    delete[] a;


}
