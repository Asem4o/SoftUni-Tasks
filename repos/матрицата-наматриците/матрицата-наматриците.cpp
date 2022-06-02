// матрицата-наматриците.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int main()
{

	int n[3][3];
	int a[3][3];
	int col, row;
	
	for (int i = 0; i < 3; i++)
	{
		row--;
		col = 3;
		for (int j = 0; j < 3; j++)
		{
			col--;
			printF << "enter " << i << j << "element for n = ";
			cin >> n[i][j];
			a[row][col] = n[i][j];

		}

	}
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			printF << a[i][j] << " ";

		}
		printF << endl;
	}

	return 0;
}

