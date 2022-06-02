
#include <stdio.h>

int main()
{



	float temCel, temFar;



	cout("Въведи температура по Фаренхайт:");
	scanf_s("%f", &temFar);
	temCel = (temFar - 32) / 1.8;
	cout("Tемпература по Целзий:%2.f", temCel);



	return 0;
}