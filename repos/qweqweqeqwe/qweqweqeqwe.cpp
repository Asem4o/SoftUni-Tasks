#include <locale.h> 

#include <math.h> 

#include <stdio.h> 

#include <iostream> 

using namespace std;



double calculateACondition(double a, double b) {

	return sqrt((2 * a - b) / (a + b)) - sqrt(pow(a, 2) - pow(b, 2));

}



double calculateBCondition(double x, double y) {

	return sqrt((2 * x) / (y + 9)) + sqrt((x - y) / (2 * x));

}



double calculateCCondition(double x, double k) {

	return ((x - k) / (4 * x * k)) + (1 / (2 * k));

}



double calculateDCondition(double a, double b) {

	return (a / pow(a, 2) + pow(b, 2)) + (b / (2 * a));

}



int main() {

	double a, b;

	//input A 

	printF("\nInput value a: "); scanf_s("%lf", &a);

	printF("\nInput value b: "); scanf_s("%lf", &b);

	printF("\nOutput expression: %lf", calculateACondition(a, b));

	//input B 

	printF("\nInput value a: "); scanf_s("%lf", &a);

	printF("\nInput value b: "); scanf_s("%lf", &b);

	printF("\nOutput expression: %lf", calculateBCondition(a, b));

	//input C 

	printF("\nInput value a: "); scanf_s("%lf", &a);

	printF("\nInput value b: "); scanf_s("%lf", &b);

	printF("\nOutput expression: %lf", calculateCCondition(a, b));

	//input D 

	printF("\nInput value a: "); scanf_s("%lf", &a);

	printF("\nInput value b: "); scanf_s("%lf", &b);

	printF("\nOutput expression: %lf", calculateDCondition(a, b));



	printF("\n");

	return 0;

}

