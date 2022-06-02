// 3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	int a, b, c;
	int greater;
	cout("\n First value is: ");
	scanf_s("%d", &a);
	cout("\n Second value is: ");
	scanf_s("%d", &b);
	cout("\n Third value is: ");
	scanf_s("%d", &c);
	if (a > b)
	{
		greater = a;
	}
	else
	{
		greater = b;
	}
	if (c > greater)
	{
		greater = c;
	}
	cout("\n The great value is %d", greater);
	return 0;
}

