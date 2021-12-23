#include <iostream>
using namespace std;

int bouncingBall(double height, double bounce, double window){
    
    if(height <= 0 || bounce <= 0 || bounce >=1 ||height <= window) return -1;
    int count = 1;
    double ballHeight = bounce * height;    
    while(ballHeight > window){
          ballHeight *= bounce;
            count += 2;        
    }
    return count;
    
}

int main() {
    cout<<bouncingBall(3,0.66,1.5);
    return 0;
}
//drops from height
//ball bounces up to height equal to height * bounce
//

// A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known.

// He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).

// His mother looks out of a window 1.5 meters from the ground.

// How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?

// Note:
// The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.

// Examples:
// - h = 3, bounce = 0.66, window = 1.5, result is 3

// - h = 3, bounce = 1, window = 1.5, result is -1 

// (Condition 2) not fulfilled).