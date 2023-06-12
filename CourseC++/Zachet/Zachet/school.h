#pragma once
#include <string>
#include "student.h"
#include "teacher.h"
#include <vector>
using namespace std;

class school
{
public:
	school() {}
	student addStudent(string n, string s, string l, int a, string p);
	void addStudent(student s);
	void addPoint(student s,item name, int point);
	void addPoint(student s, item name, vector<int> point);
	void setGroup(student s, group* Group);


	teacher addTeacher(string n, string s, string l, int a, string p);
	void addTeacher(teacher t);
	void setWork_time(teacher t,map<int, string> Work_time);
	void addActive_group(teacher t, group* Active_group);
	void addItem(teacher t, item item);
	void removeItem(teacher t, item item);

	void saveStudents();
	void saveTeachers();

private:
	int indexStudent(student s);
	int indexTeacher(teacher t);
	vector<student> _students;
	vector<teacher> _teachers;
};

