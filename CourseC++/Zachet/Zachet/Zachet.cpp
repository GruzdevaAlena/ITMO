
#include <iostream>
#include"Human.h"
#include"student.h"
#include "teacher.h"
#include"group.h"
#include <vector>
#include <map>
#include <fstream>
#include "school.h"
using namespace std;


int main()
{

    system("chcp 1251");
    school School = school();
    group* g1 = new group(123);
    group* g2 = new group(658);
    item math = item("Math");
    item rus = item("Rus lang");

    student st1 = student("Ivan", "Ivanov", "Ivanovich", 21, "88888888888");
    student st2 = student("Oleg", "Olegov", "Olegovich", 25, "89999999999");
    student st3 = student("Anastasiya", "Alexandrova", "Igorevna", 19, "87777777777");
    student st4 = School.addStudent("Sveta", "Medvedeva", "Vladislalovna", 20, "86666666666");

    School.addStudent(st1);
    School.addStudent(st2);
    School.addStudent(st3);

    School.setGroup(st1, g1);
    School.setGroup(st2, g2);
    School.setGroup(st3, g2);
    School.setGroup(st4, g2);

    vector<int> points = { 5,2,1,3,4,5 };
    School.addPoint(st1, math, 5);
    School.addPoint(st1, math, 4);
    School.addPoint(st1, rus, 5);
    School.addPoint(st2, math, points);
    School.addPoint(st3, rus, 5);
    School.addPoint(st4, rus, points);


    map<int, string> Work_time1;
    Work_time1.insert(make_pair(1, "11:20-16:30"));
    Work_time1.insert(make_pair(4, "8:00-16:30"));
    map<int, string> Work_time2;
    Work_time2.insert(make_pair(2, "11:20-16:30"));
    Work_time2.insert(make_pair(3, "8:00-16:30"));

    teacher t1 = teacher("Anastasiya", "Ivanova", "Aleksndrovna", 25, "8777777777");
    teacher t2 = School.addTeacher("Dmitriy", "Ylko", "Artemovich", 35, "844444444444");
    School.addTeacher(t1);

    School.setWork_time(t1, Work_time2);
    School.setWork_time(t2, Work_time1);
    
    School.addActive_group(t1, g1);
    School.addActive_group(t2, g2);

    School.addItem(t1, math);
    School.addItem(t2, rus);

    School.saveStudents();
    School.saveTeachers();
    delete[] g1, g2;
}

