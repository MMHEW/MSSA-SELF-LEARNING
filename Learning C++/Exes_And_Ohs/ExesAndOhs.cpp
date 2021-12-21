#include <string>
#include <iostream>

using namespace std;

string XO (string str){
    int x=0, o=0, size = str.size();
  
    for(int i = 0; i<size ; ++i){
        if(str[i] == 'x' || str[i] == 'X') x++;
        if(str[i] == 'o'|| str[i] == 'O') o++;
    }
  
    if(x == o) return "true";
  
    return "false";
}


int main(){
    cout<<"Test 1: "<<endl;
    cout << XO("ooxx")<<endl;
    cout<< "-------------------------------"<<endl;

    cout<<"Test 2: "<<endl;
    cout << XO("xooxx")<<endl;
    cout<< "-------------------------------"<<endl;

    cout<<"Test 3: "<<endl;
    cout << XO("ooxXm")<<endl;
    cout<< "-------------------------------"<<endl;

    cout<<"Test 4: "<<endl;
    cout << XO("zpzpzpp")<<endl;
    cout<< "-------------------------------"<<endl;

    cout<<"Test 5: "<<endl;
    cout << XO("zzoo")<<endl;
    cout<< "-------------------------------"<<endl;
    return 0;
}

// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false