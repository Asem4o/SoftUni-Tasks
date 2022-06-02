// maticata.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
	int one[3][3];
	int second[3][3];
	int r, c;
	printF << "enter row" << endl;
	cin >> r;
	printF << "enter col" << endl;
	cin >>c;
	for (int i = 0; i <r; i++)
	{
		for (int j = 0; j < c; j++)
		{
			printF << "enter " << i << j << " element for first matrix = ";
			cin >> one[i][j];
			printF << one[i][j]<<" ";
		}
	}
	for (int  i = 0; i < r; i++)
	{
		printF << endl;
		for (int j = 0; j <c; j++)
		{
			printF << one[i][j] <<" ";
			if (j == c - 1);
				
				
		}
	}
	for (int  i = 0; i < r; i++)
	{
		printF << endl;
		for (int j = 0; j < c; j++)
		{
			second[j][i] = one[i][j];
		}
	}
	for (int i = 0; i < c; i++)
	{
		for  (int j= 0; j < r; j++)
		{
			printF << second[i][j]<<" ";
			if (j == r - 1)
				printF << endl;
			
		}
	}
	printF << endl;
	return 0;
}
