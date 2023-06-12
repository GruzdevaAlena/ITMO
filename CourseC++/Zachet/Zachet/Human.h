#pragma once
#include <string>
#include <sstream>

using namespace std;


class Human
{
public:
	Human(string name, string surname, string last_name,int age,string phone);
	virtual string Display() const;


private:
	string Name;
	string Surname;
	string Last_name;
	string Phone;
	int Age;
};

