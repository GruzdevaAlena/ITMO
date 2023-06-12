#pragma once
#include "Human.h"
#include "group.h"
#include <map>
#include <vector>
#include "item.h"
class teacher:public Human
{
public:
	teacher(string name, string surname, string last_name, int age, string phone);
	string Display() const;
	void setWork_time(map<int, string> Work_time);
	void addActive_group(group *Active_group);
	void addItem(item item);
	void removeItem(item item);
	string fullName();
private:
	vector<item> items;
	map<int, string> Work_time;
	vector<group> Active_group;
};

