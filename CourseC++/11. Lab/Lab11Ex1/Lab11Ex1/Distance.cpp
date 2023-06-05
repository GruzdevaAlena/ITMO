#include "Distance.h"
Distance Distance::operator+ (const Distance& d2) const
{
	int f = feet + d2.feet;
	float i = inches + d2.inches;
	if (i >= 12.0)
	{
		i -= 12.0;
		f++;
	}
	return Distance(f, i);
}
Distance Distance::operator- (const Distance& d2) const
{
	int f = feet - d2.feet;
	float i = inches - d2.inches;
	if (i >= 12.0)
	{
		i -= 12.0;
		f++;
	}
	return Distance(f, i);
}


std::ostream& operator<< (std::ostream& out, const Distance& dist)
{
	out << dist.feet << "\' - " << dist.inches << "\'\n";
	return out;
}
