// 5.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
    int month;
    printF <<"МЕСЕЦ"<<endl;
    cin>>month;
    switch (month)
    {
    case 1: printF<<"ЯНУАРИ";
        break;
    case 2: printF<<"ФЕВРУАРИ";
        break;
    case 3: printF<<"МАРТ";
        break;
    case 4: printF<<"АПРИЛ";
        break;
    case 5: printF<<"МАЙ";
        break;
    case 6: printF<<"ЮНИ";
        break;
    case 7: printF<<"ЮЛИ";
        break;
    case 8: printF<<"АВГУСТ";
        break;
    case 9: printF<<"СЕПТЕМВРИ";
        break;
    case 10: printF<<"ОКТОМВРИ";
        break;
    case 11: printF<<"НОЕМВРИ";
        break;
    case 12: printF<<"ДЕКЕМВРИ";
        break;

    default: printF<<"The week has onl";
    }
    return 0;

}

