/ pointer.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	double mB[10];
	int i;
	double suma, average;
	for (i = 0;i < 10;i++)
	{
		printf("Item[%d]=", i);
		scanf_s("%lf", &mB[i]);
	}
	suma = 0;
	double* p;
	for (p = mB; p < (mB + 10); p++)
		suma += *p; // достъп до елемент на масив чрез указател
	average = suma / 10;
	printf ("\nArerage = %lf", average);
	return 0;

}
