// celsiusToFaren.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
    double celsius, faren;
    string text;
    printF << "enter C or F:" << endl;
    cin >>text;
    if (text =="C")
    {
        printF << "enter temperatura of faren" << endl;
        cin >> faren;
        celsius = faren - 32 / 1.8;
        printF <<"The tem of Celsius is:"<<endl<< celsius << endl;
    }
    if (text =="F")
    {
        printF << "enter temperatura of celsius" << endl;
        cin >> celsius;
        faren = celsius - 32 / 1.8;
        printF << "The tem of Faren is:" << endl << faren << endl;
    }
    else
    {
        printF << "Wrong TEMP" << endl;
    }
    
    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
