#pragma once
class funMath
{

	public: bool isEven(int x) {

		bool flag;
		if (x % 2 != 0) {
			flag = false;
		}

		else {
			flag = true;
		}

		return flag;
	}

	public: int addition(int x, int y) {

		return x + y;

	}
	public: int subtraction(int x, int y) {

		return x - y;

	}
	public: int multiply(int x, int y) {

		return x * y;

	}
	public: double divide (int x, int y) {

		return x / y;

	}

}