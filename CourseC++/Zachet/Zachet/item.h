#pragma once
#include <string>
using namespace std;

class item
{
public:
	item();
	item(string name);
	string getName()const;
private:
	string name;
};

