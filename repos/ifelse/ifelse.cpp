// ifelse.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
	int a, b,maks;
	cout("ENTER FIRST NUMBER!!!!");
	scanf_s("%d",& a);
	cout("ENTER second NUMBER!!!!");
	scanf_s("%d",& b);
	if (a<b)
	{
		maks = b;
		cout("maks=%d",maks);
		
	}
	else
	{
		maks = a;
		cout("maks=%d", maks);
	}
	
	return 0;
}

