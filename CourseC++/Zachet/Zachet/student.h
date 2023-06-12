#pragma once
#include "Human.h"
#include"group.h"
#include <vector>
#include "item.h"
#include <map>
class student:public Human
{
public:
	student(string name, string surname, string last_name,int age,string phone);
	string Display() const;
	void addPoint(item name,int point);
	void addPoint(item name,vector<int> point);
	void setGroup(group *Group);
	string fullName();
private:
	vector<int> Point;
	map<string, vector<int>> Points;
	group* Group;
	
};

