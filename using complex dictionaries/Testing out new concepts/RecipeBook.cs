using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_out_new_concepts
{
    class RecipeBook
    {

        private readonly Dictionary<string, Action> _recipes;
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
       

        //constructor
        public RecipeBook(Func<string> inputProvider, Action<string> outputProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _recipes = new Dictionary<string, Action>
            {
                {"beer", ServeBeer },
                {"juice", ServeJuice},
                {"reverse", reverseString},
                {"exit", exitProgram},
            };
        }
        
        public void MakeDrink(string drinkName)
        {
            _recipes[drinkName]();
        }

        public IEnumerable<string> GetAvailableDrinkNames()
        {
            return _recipes.Keys;
        }

        public void ServeBeer()
        {
            _outputProvider("woah woah woah how old are you?");
            int age = int.Parse(_inputProvider());
            ageCheck(age);
        }

        public void ServeJuice()
        {
            _outputProvider("Have some nice cold JUICE\n");
        }

        public void ageCheck(int age)
        {

            if (age >= 18)
            {
                _outputProvider("Here's your warm beer sir\n");
                return;
            }
            _outputProvider("Sorry bud your are not old enough");

        }

        //public void reverseString()
        //{
        //    _outputProvider("Please type a word or phrase you would like backwards.");
        //    string initial;
        //    initial = _inputProvider();            
        //    int length = initial.Length;
        //    char[] reverse = new char[length];
        //    string final = "";
            
        //    for (int i = 0; i<initial.Length; i++)
        //    {
        //        reverse[i] = initial[(length-1) - i];
        //    }

        //    for(int i = 0; i<reverse.Length; i++)
        //    {
        //        final += reverse[i];
        //    }
            
        //    _outputProvider($"{final} is the word reversed");


        //}
        public void reverseString()
        {
            _outputProvider("what word or phrase would you like reversed?");
            string s = _inputProvider();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string final = new string(charArray);
            _outputProvider($"{final} is the word reversed");
        }

        public void exitProgram()
        {
            _outputProvider("Thank you for coming have a great day!");
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(0);
        }



    }
}
