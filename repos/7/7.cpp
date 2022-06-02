// 7.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	int mA[10], i;
	for (i = 0; i < 10; i++) //въвеждане стойности на елементите
	{
		cout("Item[%d]=", i);
		scanf_s("%d", &mA[i]);
	}
	cout("\n"); // извеждане стойностите на елементите
	for (i = 9; i >= 0; i--) cout("%d ", mA[i]);
	return 0;

}

