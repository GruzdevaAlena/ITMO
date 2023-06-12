#include "teacher.h"



teacher::teacher(string name, string surname, string last_name, int age, string phone) :Human(name, surname, last_name, age, phone) 
{}

void teacher::setWork_time(map<int, string> Work_time) {
	this->Work_time = Work_time;
}
void teacher::addActive_group(group *Active_group) {
	this->Active_group.push_back(*Active_group);
}
string teacher::fullName() {
	return Human::Display();
}
string teacher::Display() const {
	ostringstream Info;
	Info << Human::Display();
	Info << "Groups: ";
	for (auto it = begin(Active_group); it != end(Active_group); ++it) {
		group g = *it;
		if (next(it) != end(Active_group))
			Info << g.getGroup() << ", ";
		else
			Info << g.getGroup();
	}
	Info << endl << "Work time: ";
	for (auto& item : Work_time) {
		Info << item.first << "day : " << item.second << " | ";
	}
	Info << endl << "Items: ";
	for (auto it = begin(items); it != end(items); ++it) {
		item i = *it;
		if (next(it) != end(items))
			
			Info << i.getName();
		else
			Info << i.getName();
	}
	Info << endl<<endl;
	return Info.str();
}
void teacher::addItem(item item) {
	items.push_back(item);
}
void teacher::removeItem(item item) {
	for (int i = 0; i < items.size(); i++) {
		if (items[i].getName() == item.getName()) {
			items.erase(items.begin() + i);
		}
	}
}