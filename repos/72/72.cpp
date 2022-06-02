// 72.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
    const int M = 5;
    const int N = 4;
    int matrix[M][N];
    int i, j;

    for (i = 0;i < M;i++)
    {
        for (j = 0;j < N;j++)
        {
            cout("Item[%d][%d]=", i, j);
            scanf_s("%d", &matrix[i][j]);
        }
    }

    for (i = 0;i < M;i++)
    {
        cout("\n");
        for (j = 0;j < N;j++)
        {
            cout("%d ", matrix[i][j]);
        }
    }


    return 0;
}




