using System;

namespace Testing_out_new_concepts
{
    class bartender
    {
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        private readonly RecipeBook _recipeBook; //used to hold the constructed RecipeBook including its dictionary
        public static bool flag = true; //made static so RecipeBook can change it
        public bartender(Func<string> inputProvider, Action<string> outputProvider, RecipeBook recipeBook)
        {
            _inputProvider = inputProvider; //use input/output provides to hold whatever method is used to accept input and display output
            _outputProvider = outputProvider;
            _recipeBook = recipeBook;
        }

        public void AskForDrink()
        {
            
            
            do
            {
                //displays the dictionary keys (to use their availiable methods) to the user seperated by commas
                _outputProvider($"Hello please chose what drink you would like {string.Join(", ", _recipeBook.getAvailableDrinkNames())}"); 
                try
                {
                    _recipeBook.makeDrink(_inputProvider().ToLower()); //calls the makeDrink method with the input put to lowercase
                }
                //used to catch exceptions most notably when the user supplies a invalid input
                catch(Exception e)
                {
                    _outputProvider("Im sorry but that it not a valid option...please try again\n\n(Press enter to continue)");
                    _inputProvider();
                    Console.Clear();
                }
            }
            while (flag); //keeps bartender looped unless tutor is called
            
        }
    }
}
