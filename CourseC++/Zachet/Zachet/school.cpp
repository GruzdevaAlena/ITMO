#include "school.h"
#include <iostream>
#include <fstream>

int school::indexStudent(student s) {
	for (int i = 0; i < _students.size(); i++) {
		if (_students[i].fullName() == s.fullName()) {
			return i;
		}
	}
}

int school::indexTeacher(teacher t) {
	for (int i = 0; i < _teachers.size(); i++) {
		if (_teachers[i].fullName() == t.fullName()) {
			return i;
		}
	}
}

student school::addStudent(string n, string s, string l, int a, string p) {
	student s1 = student(n, s, l, a, p);
	_students.push_back(s1);
	return s1;
}
void school::addStudent(student s) {
	_students.push_back(s);
}

void school::addPoint(student s, item name, int point) {
	_students[indexStudent(s)].addPoint(name, point);
}
void school::addPoint(student s, item name, vector<int> point) {
	_students[indexStudent(s)].addPoint(name, point);
}
void school::setGroup(student s, group* Group) {
	_students[indexStudent(s)].setGroup(Group);
}


teacher school::addTeacher(string n, string s, string l, int a, string p) {
	teacher t1 =  teacher(n, s, l, a, p);
	_teachers.push_back(t1);
	return t1;
}
void school::addTeacher(teacher t) {
	_teachers.push_back(t);
}

void school::setWork_time(teacher t, map<int, string> Work_time) {
	_teachers[indexTeacher(t)].setWork_time(Work_time);
}
void school::addActive_group(teacher t, group* Active_group) {
	_teachers[indexTeacher(t)].addActive_group(Active_group);
}
void school::addItem(teacher t, item item) {
	_teachers[indexTeacher(t)].addItem(item);
}
void school::removeItem(teacher t, item item) {
	_teachers[indexTeacher(t)].removeItem(item);
}

void school::saveStudents() {
	std::ofstream out;
	out.open("students.txt");
	if (out.is_open())
	{
		for (int i = 0; i < _students.size(); i++) {
			out << _students[i].Display() << std::endl;
		}
	}
	out.close();
}
void school::saveTeachers() {
	std::ofstream out;
	out.open("teachers.txt");
	if (out.is_open())
	{

		for (int i = 0; i < _teachers.size(); i++) {
			out << _teachers[i].Display() << std::endl;
		}
	}
	out.close();
}