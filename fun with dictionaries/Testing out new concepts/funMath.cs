using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_out_new_concepts
{
    class funMath
    {

        private readonly Dictionary<string, Action> _subjects;
        private readonly Func<string> _inputProvider; 
        private readonly Action<string> _outputProvider;


        //constructor
        public funMath(Func<string> inputProvider, Action<string> outputProvider)
        {
            _inputProvider = inputProvider; //used in case logger is wanted to be used instead of Console (default)
            _outputProvider = outputProvider; //used in case logger is wanted to be used instead of Console (default)
            _subjects = new Dictionary<string, Action>
            {
                //This dictionary uses key words to call methods based on user input in the Tutor class
                {"word reverse", reverseString},
                {"fibbonacci", fibbonacci},
                {"factorial", factorial},
                {"isogram", isogram },
                {"exit", exitProgram},

            };
        }


        //called by the Tutor class while passing a key to the dictionary obove
        public void teachMe(string drinkName)
        {
            _subjects[drinkName]();
        }

        //used to pass all availiable keys to subjects to be called by Tutor Class
        public IEnumerable<string> getAvailableSubjects()
        {
            return _subjects.Keys;
        }
 
    

        //my take on the classic fibbonacci sequence
        //fibbonacci seqwuence is defined as  the first number of the sequence is 0, the second number is 1,
        //and the nth number is the sum of (n - 1)th and (n -2)th numbers. 
        public void fibbonacci()
        {

            int a = 0, b = 1, c = 0; //a and b are used to hole the prior numbers while c is used to hold the end result
            _outputProvider("Please give me a number to run through the fibbonacci sequence");
            int len = int.Parse(_inputProvider()); //holds how long the fibbonacci sequence runs based on user input

            //loop to preform the function
            for (int i = 2; i < len; ++i)
            {
                c = a + b;
                a = b;
                b = c;
            }

            _outputProvider($"The solution is  {c}");
            System.Threading.Thread.Sleep(2000); //used to hold the application for 2 seconds so the screen can be read before clearing the screen.
            Console.Clear();

        }
        //reverseString is my take on a white board question i was given
        public void reverseString()
        {
            _outputProvider("what word or phrase would you like reversed?");
            string s = _inputProvider(); //holds the initial input by the user
            char[] charArray = s.ToCharArray(); //turns the input into an array
            Array.Reverse(charArray); //uses build in function to reverse the array
            string final = new string(charArray); //changes the array back into a string
            _outputProvider($"{final} is the word reversed"); //prints
            System.Threading.Thread.Sleep(2000); //used to hold the application for 2 seconds so the screen can be read before clearing the screen.
            Console.Clear();
        }
        //factorial is another classic algorithm
        //factorial is defined as the product of an integer and all the integers below it; e.g. factorial four ( 4! ) is equal to 24.
        public void factorial()
        {
            _outputProvider("Please select a number to solve the factorial");
            int solve = int.Parse(_inputProvider());
            for(int i = solve - 1; i >= 1; --i)
            {
                solve = (solve * i);
            }
            _outputProvider($"\n\nThe result is {solve} lets learn some more!");
            System.Threading.Thread.Sleep(2000); //used to hold the application for 2 seconds so the screen can be read before clearing the screen.
            Console.Clear();

        }
        //an isogram is a word in which there are no repeating characters
        public void isogram()
        {
            _outputProvider("Please provide me any word or phrase to test and see if it is an isogram!");
            string str;
            str= _inputProvider();
            //this bool uses build in methods to make the string lowercase, then count all distinct characters and tests to see if it matches the original length
            bool testFlag = str.ToLower().Distinct().Count() == str.Length; 
            if (testFlag)
            {
                _outputProvider($"The word or phrase {str} is an isogram!");
                System.Threading.Thread.Sleep(2000);//used to hold the application for 2 seconds so the screen can be read before clearing the screen.
                Console.Clear();
                return;//breaks the method so an else statement is not needed
            }
            _outputProvider($"The word or phrase {str} is not an isogram.\n(This means there is one or more letters that are the same");
            System.Threading.Thread.Sleep(2000);//used to hold the application for 2 seconds so the screen can be read before clearing the screen.
            Console.Clear();
        }

        public void exitProgram()
        {
            _outputProvider("Thank you for coming have a great day!");
            System.Threading.Thread.Sleep(1000);//used to hold the application for 1 seconds before exiting the application completely
            Environment.Exit(0);
        }


    }
}
