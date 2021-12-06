// Simple summing -- day one.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include "funMath.h"
using namespace std;



string fullName() {

    string fullName;
    cout << "Type your full name: ";
    getline(cin, fullName); //still does not execute since getline cannot be executed when cin is executed in the same class?
    cout << "Your name is: " << fullName << "\n\n";
   // fullName = " Matthew Miller";
    return fullName;

}

int main()
{
    
    int firstNum;
    int secondNum;
    funMath newClass;

   cout << "Please enter a number \n";
    cin >> firstNum;
    secondNum = 10;
    cout << "Please enter a second number \n";
    cin >> secondNum;
    int result;

    result = newClass.addition(firstNum, secondNum);
    
    cout << "The sum of these numbers is  " << result << "\n";

    cout << "enter a number and i will tell you if it is even.";
    
    int evenOdd;

    cin >> evenOdd;
    
    funMath newClass;

    bool even;
    even = newClass.isEven(evenOdd);

    if (even) {
        cout << "the number you have entered is even! \n";
    }
    else {
        cout << "the number you have entered is odd! \n";
    }
    //cin.ignore() is used after a group of cin arguments to allow the use of getline(cin,arg) 
    cin.ignore();


    string name = fullName();
       
    cout << "Your name is " << name.length() - 1  << " characters long";


    return 0;
}

