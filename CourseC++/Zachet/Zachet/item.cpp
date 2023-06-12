#include "item.h"
#include <string>

item::item(string name) {
	this->name = name;
}
string item::getName() const{
	return this->name;
}