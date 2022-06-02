// ConsoleApplication3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
    int x, y, z;
    printf("Enter first number:");
    scanf_s("%d", &x);
    printf("Enter second number:");
    scanf_s("%d", &y);
    if (x > y) z = x;
    else z = y;
    printf("\nThe first number is %d", x);
    printf("\nThe second number is %d", y);
    printf("\nThe great number is %d", z);
    return 0;
}

