#include <iostream>
#include <vector>
using namespace std;



int findPlace(vector<int> nums){
  	int ActualNum, NumberTimeShown;
	int size = nums.size();

	for(int i = 0; i<size; ++i){
		NumberTimeShown = 0;
		ActualNum = nums.at(i);
		for(int j = 0; j<size; ++j){
			if(nums.at(j) == nums.at(i)) NumberTimeShown++;
		}
		if(NumberTimeShown %2 != 0 && NumberTimeShown !=0) return ActualNum;

	}


	return 0;
}




int main()
{
	vector<int> input;
	int atPlace;
	input.insert(input.end(), { 1,2,2,3,3,3,4,3,3,3,2,2,1 });

	atPlace = findPlace(input);
	cout<<"the answer is: " << atPlace <<endl;
	
	return 0;
}


// Given an array of integers, find the one that appears an odd number of times.

// There will always be only one integer that appears an odd number of times.

// Examples
// [7] should return 7, because it occurs 1 time (which is odd).
// [0] should return 0, because it occurs 1 time (which is odd).
// [1,1,2] should return 2, because it occurs 1 time (which is odd).
// [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
// [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).