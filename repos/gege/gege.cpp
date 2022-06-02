// gege.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<math.h>
int main()
{
	int a, b, c, d;
	cout("Enter Number");
	scanf_s("%d",& a);
	cout("\nEnter Second Number");
	scanf_s("%d", &b);
	c = (a+ pow(2,b));
	cout("%ld",c);
	return 0;
}
