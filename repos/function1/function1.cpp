// function1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;

int sum(int a, int b) // дефиниран прототип на функцията
{
	return a + b;
	
}

int main()
{
	int a, b;
	printf("first digit:");
	scanf_s("%d",& a);
	printf("\nsecond digit:");
	scanf_s("%d", &b);
	return 0;
}