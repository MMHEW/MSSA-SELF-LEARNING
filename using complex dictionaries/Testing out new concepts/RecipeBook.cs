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
            //used instead of a switch case in the bartender method.
            //allows a list that is easier to edit and add to.
            _recipes = new Dictionary<string, Action>
            {
                {"beer", serveBeer },
                {"juice", serveJuice},                
                {"tutor" , getTutor },
                {"exit", exitProgram},

            };
        }
        
        public void makeDrink(string drinkName)
        {
            //used to call the dictionary actions by their keys
            _recipes[drinkName]();
        }

        //used to store all the keys from the _recipes dictionary
        public IEnumerable<string> getAvailableDrinkNames()
        {
            return _recipes.Keys;
        }

        //when asked to serve a beer it asks how old the user is before sending it to the ageCheck method
        public void serveBeer()
        {
            _outputProvider("woah woah woah how old are you?");
            int age = int.Parse(_inputProvider());
            ageCheck(age);
        }
        //just serves juice
        public void serveJuice()
        {
            _outputProvider("Have some nice cold JUICE\n");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        //checks to ensure the user is old enough to drink (21 in the USA)
        //if they are they get served a nice warm beer and if not they get told they are not old enough.
        public void ageCheck(int age)
        {

            if (age >= 21)
            {
                _outputProvider("Here's your warm beer sir\n");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return;
            }
            _outputProvider("Sorry bud your are not old enough");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

        }
        //used to break the bartender loop so it goes back to the main program and calls the tutor class
        public void getTutor()
        {
            _outputProvider("Let me go get them, wait right here for one second.");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            bartender.flag = false;
            return;

        }
        //used to force the program to exit after a short 1 second delay
        public void exitProgram()
        {
            _outputProvider("Thank you for coming have a great day!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }



    }
}
