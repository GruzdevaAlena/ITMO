﻿#include <iostream>
#include <string>
#include "student.h"
using namespace std;
int main()
{
	system("chcp 1251");

	string name;
	string last_name;
	cout << "Name: ";
	getline(std::cin, name);
	cout << "Last name: ";
	getline(std::cin, last_name);
	string status;
	int id;
	cout << "Status: ";
	getline(std::cin, status);
	cout << "Id: ";
	cin >> id;



	IdCard* idc = new IdCard(id, status);
	Student* student02 = new Student(name, last_name, idc);
	// Оценки
	int scores[5];
	// Сумма всех оценок
	int sum = 0;
	// Ввод промежуточных оценок
	for (int i = 0; i < 5; ++i) {
		cout << "Score " << i + 1 << ": ";
		cin >> scores[i];
		// суммирование
		sum += scores[i];
	}
	// Сохранение имени и фамилии в объект класса Students
	student02->set_name(name);
	student02->set_last_name(last_name);
	// Сохраняем промежуточные оценки в объект класса Student
	student02->set_scores(scores);
	// Считаем средний балл
	float average_score = sum / 5.0;
	// Сохраняем средний балл в объект класса Student
	student02->set_average_score(average_score);
	// Выводим данные по студенту
	cout << "Average ball for " << student02->get_name() << " "
		<< student02->get_last_name() << " is "
		<< student02->get_average_score() << endl;
	cout << "IdCard: " << student02->getIdCard().getNumber() << endl;
	cout << "Category: "<< student02->getIdCard().getCategory() << endl;

	return 0;
}