#include <iostream>

using namespace std;

string EndsWith (string str, string ending){

    int strSize = str.size() - 1;

    for(int i = ending.size() - 1; i>=0; --i){
        if (str.at(strSize) != ending.at(i)) return "false";

        strSize--;
    }

    return "true";
}


int main(){
    cout<<"Test 1:  \n ---------------------\n" << EndsWith("abc", "bc") << endl; 

    cout<<"Test 2:  \n ---------------------\n" <<EndsWith("abc", "d")<< endl; 
    return 1;
}

// Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

// Examples:

// solution('abc', 'bc') // returns true
// solution('abc', 'd') // returns false