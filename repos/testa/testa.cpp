// testa.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
#include <stdio.h>
int main() 
{
    
    int a, b;
    printF << "enter raw in matrix" << endl;
    cin >> a;
    printF << "enter col in matrix" << endl;
    cin >> b;
    int matrix[1000][10000];
    int i, j;
    for (i = 0;i < a;i++)
    {
        printF << endl;
        for (j = 0;j < b;j++)
        {
            printF << "enter elements of matrix" << endl;
            cin >> matrix[i][j];
        }
    }
    for (i = 0;i < a;i++)
    {
        printF << endl;
        for (j = 0;j < b;j++)
        {
            printF << matrix[i][j] << " ";
        }
    }
    return 0;
}
