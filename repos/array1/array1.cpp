// array1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	double mB[10];
	int i;
	double suma, average;
	for (i = 0;i < 10;i++) //въвеждане стойностите на елементите
	{
		cout("Item[%d]=", i);
		scanf_s("%lf", &mB[i]);
	}
	suma = 0; // намиране сумата на елементите
	for (i = 0; i < 10; i++) suma += mB[i];
	average = suma / 10; // намиране на средноаритметична стойност
	cout("\nAverage = %lf", average);
	return 0;
}

