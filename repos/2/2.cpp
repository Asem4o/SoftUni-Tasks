// 2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	int x;
	cout("Enter a number:");
	scanf_s("%d", &x);
	if(x % 2)
	{
		cout("\nOdd number");
	}
	if (!(x % 2))
	{
		cout("\nEven number");
	}
	return 0;
}



