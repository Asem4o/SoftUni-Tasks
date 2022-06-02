#include <stdio.h>
#include <math.h>
int main()
{
    double firstNumber, secondNumber, product, product1, product2, product3 ;
    printf_s("Enter two numbers: ");

    // Stores two floating point numbers in variable firstNumber and secondNumber respectively
    scanf_s("%lf %lf", &firstNumber, &secondNumber);  
 
    // Performs multiplication and stores the result in variable productOfTwoNumbers
    product = firstNumber * secondNumber;  
     product1 = firstNumber + secondNumber;
      product2 = firstNumber - secondNumber;
       product3 = firstNumber / secondNumber;
        
    // Result up to 2 decimal point is displayed using %.2lf
    printf_s("Product = %.2lf\n", product);
     printf_s("Product1 = %.2lf\n", product1);
      printf_s("Product2 = %.2lf\n", product2);
       printf_s("Product3 = %.2lf\n", product3);


  
    return 0;
}
