#include "student.h"
#include <iostream>

student::student(string name, string surname, string last_name,int age,string phone):Human(name,surname,last_name,age,phone)
{}

void student::setGroup(group *group) {
	this->Group = group;
}
string student::Display() const{
	ostringstream Info; 
	Info << Human::Display();
	Info << "Group: "<< Group->getGroup() << endl;
	Info << "Points: ";
	
	for (auto it = begin(Points); it != end(Points); ++it) {
		Info << (*it).first << ": ";
		for (auto i = begin((*it).second); i != end((*it).second); ++i) {
			if (next(i) != end((*it).second)) {
				Info <<(*i) << ", ";
			}
			else
				Info << (*i);
		}
		Info << endl;

	}
	Info << endl << endl;
	return Info.str();

}
string student::fullName() {
	return Human::Display();
}
void student::addPoint(item name, int p) {

	for (auto it = begin(Points); it != end(Points); ++it) {
		if ((*it).first == name.getName()) {
			(*it).second.push_back(p);
			return;
		}
	}

	vector<int> pp;
	pp.push_back(p);
	Points.insert(make_pair(name.getName(), pp));


}
void student::addPoint(item name, vector<int> p) {

	for (auto it = begin(Points); it != end(Points); ++it) {
		if ((*it).first == name.getName()) {
			for (auto i = begin(p); i != end(p); ++i) {
				(*it).second.push_back(*i);
			}
			return;
		}
	}
	Points.insert(make_pair(name.getName(), p));
}