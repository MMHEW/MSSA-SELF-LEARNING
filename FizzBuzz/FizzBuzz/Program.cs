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

            string output;
            int input;
            Console.WriteLine("How high would you like me to count?");
            input = int.Parse(Console.ReadLine());
            
            for(int i = 1; i<=input; ++i)
            {
                output = "";
                if (i % 3 == 0) output += "Fizz";
                if (i % 5 == 0) output += "Buzz";

                if (output == "") Console.WriteLine(i);
                else Console.WriteLine(output);


            }

            Console.ReadKey();

        }
    }
}
