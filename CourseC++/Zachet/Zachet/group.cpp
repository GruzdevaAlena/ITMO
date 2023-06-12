#include "group.h"

group::group(int id) {
	this->id = id;
}
string group::getGroup() const{
	return to_string(id);
}
