// finalMatrixForTest.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
    int firstMatrix[33][33];
    int reversedMatrix[33][33];
    int sumMatrix[33][33];
    int sumMatrix1[33][33];
    int col, row, sum, a, b;
    printF << "enter first digit" << endl;
    cin >> a;
    printF << "enter second digit" << endl;
    cin >> b;
    col = 3;
    row = 3;
    sum = 3;

    for (int i = 0; i < a; i++)
    {
        row--;
        col = 3;
        for (int j = 0; j < b; j++)
        {
            col--;
            printF << "enter " << i << j << " element for first matrix = ";
            cin >> firstMatrix[i][j];
            reversedMatrix[row][col] = firstMatrix[i][j];
            sumMatrix1[i][0] = reversedMatrix[row][col];
        }
    }
    
    printF << endl << "reversed matrix" << endl;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
          printF << reversedMatrix[i][j] << " ";
            
            
        }
        printF << endl;
    }

    printF << "element of matrix" << endl;
    for (int i = 0; i <a; i++)
    {
        for (int j = 0; j < 1; j++)
        {

            printF << sumMatrix1[i][j] << " ";

        }
        printF << endl;
    }

    return 0;
}


