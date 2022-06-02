// ConsoleApplication2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
    int x, y, z;
    cout("Enter first number:");
    scanf_s("%d", &x);
    cout("Enter second number:");
    scanf_s("%d", &y);
    if (x > y) z = x;
    else z = y;
    cout("\nThe first number is %d", x);
    cout("\nThe second number is %d", y);
    cout("\nThe great number is %d", z);
    return 0;
}
