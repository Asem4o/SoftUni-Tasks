// 4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;
int main()
{
    int a, b, c;
    double d, x1, x2;
    printf("\n a=");
    scanf_s("%d", &a);
    printf(" b=");
    scanf_s("%d", &b);
    printf(" c=");
    scanf_s("%d", &c);
    if (a != 0)
    {
        d = b * b + 4 * a * c; 
        if (d < 0) printf("НРК!");
        else
        {
            if (d == 0)
            {
                x1 = -b / (2 * a);
                printf("\n Един двоен корен x=%f", x1);
            }
            else
            {
                x1 = (-b + sqrt(d)) / (2 * a);
                x2 = (-b - sqrt(d)) / (2 * a);
                printf("\n Корение на уравнението са:%f, %f", x1, x2);
            }
        }
    }
    else
    {
         printf("Уравнението е линейно");
    }
  
    return 0;
}

