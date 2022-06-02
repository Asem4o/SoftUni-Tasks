// theFockingReality.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
void TriangleType(double a, double b, double c)
{
    double a, b, c;
    cin >> a;
    cin >> b;
    cin >> c;

    if (a == b && b == c)
    {
        cout << 1;
    }
    else
    {
        cout << 0;
    }
  
}