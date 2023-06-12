#include "Human.h"

Human::Human(string name, string surname, string last_name,int age,string phone) {
	this->Name = name;
	this->Surname = surname;
	this->Last_name = last_name;
	this->Age = age;
	this->Phone = phone;
}
string Human::Display() const{

	 ostringstream Fname; 
	 Fname << "Full name: " << this->Surname << " " << this->Name << " " << this->Last_name << endl << "Age:" << this->Age <<endl<< "Phone: " << this->Phone<<endl;
	 return Fname.str();
}