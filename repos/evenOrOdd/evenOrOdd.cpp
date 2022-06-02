// evenOrOdd.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	int a, b;
	cout("ENTER FIRST NUMBER");
	scanf_s("%d",& a);
	cout("\nENTER SECOND NUMBER");
	scanf_s("%d",& b);
	if (a %2 == 0)
	{
		cout("even");
	}
	else
	{
		cout("odd");
	}
	return 0;
}

