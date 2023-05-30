

#include <iostream>
#include "Time.h"
using namespace std;
int main()
{
    system("chcp 1251");

    Time *time1 = new Time(5,-10,61);
    Time *time2 = new Time(4, 12, 59);
    Time *time3 = new Time();
    time1->Display();
    cout << endl;
    time2->Display();
    cout << endl;
    time3->Display();
    cout << endl;
    *time3 = time3->sumTime(*time1, *time2);
    time3->Display();
    delete time1;
    delete time2;
    delete time3;
}

