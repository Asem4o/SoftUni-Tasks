// pyramide.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main() {
    int row,counter,number;
    counter = 0;
    printF << "enter rows" << endl;
    cin >> row;
    printF << "enter number to start";
    cin >> number;
   
    for (int i = 0; i < row; i++)
    {
        for (int j = row; j > i; j--)
        {      
            number-=number;
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            number++;
            printF <<" "<<number;
        }
        printF << endl;
    }
    return 0;
}