#include <iostream>
#include <sstream>

using namespace std;

string CheckFizzBuzz(int numCheck){
    
    string result = "";

    stringstream ss;

    if(numCheck % 3 == 0) result += "Fizz";

    else if(numCheck % 5 == 0) result += "Buzz";

    if(result != "") return result;

    ss<<numCheck;
    return ss.str();    
}

int main()
{
    int uppLim;
    cout << "Please enter the number you want to count up to: " << endl;
    cin >> uppLim;

    for(int i = 1; i<uppLim; ++i)
        cout<< CheckFizzBuzz(i)<< endl;
    

    return 0;
}