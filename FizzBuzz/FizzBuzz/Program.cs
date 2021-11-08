using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the best way i have thought of to do the classic FizzBuzz. This version allows you to change 3 and 5 easily or add to the FizzBuzz without
            //drastically changing the program (just copy pasting and changing the number/words)
            string output;
            int input;
            Console.WriteLine("How high would you like me to count?");
            input = int.Parse(Console.ReadLine()); //takes input 
            
            for(int i = 1; i<=input; ++i)
            {
                output = ""; //used to hold the output if it is a Fizz and or Buzz
                if (i % 3 == 0) output += "Fizz"; //if there is no remainder after dividing by 3 it is a Fizz and fizz is added to the string (is divisible by 3)
                if (i % 5 == 0) output += "Buzz"; //if there is no remainder after dividing by 5 it is a Fizz and fizz is added to the string (is divisible by 5)
                //due to the Fizz and Butt being both checked seperately and Fizz and Buzz being concatenated to the string if it is both divisible by 3 and 5 
                //then it will display FizzBuzz
                if (output == "") Console.WriteLine(i); //if its not a fizz and or buzz the number wil be displayed
                else Console.WriteLine(output); //if output is not empty 


            }

            Console.ReadKey(); //used to hold the console in place so you can read the result

        }
    }
}
