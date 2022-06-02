#include <stdio.h>
int main()
{
	double A, B, temp;



	cout("Enter A: ");
	scanf_s("%lf", &A);



	cout("Enter B: ");
	scanf_s("%lf", &B);
	temp = A;
	A = B;

	B = temp;

	cout("\nAfter swapping, A = %.2lf\n", A);
	cout("After swapping, B = %.2lf\n", B);



	return 0;
}