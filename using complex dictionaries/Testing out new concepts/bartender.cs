using System;

namespace Testing_out_new_concepts
{
    class bartender
    {
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        private readonly RecipeBook _recipeBook;

        public bartender(Func<string> inputProvider, Action<string> outputProvider, RecipeBook recipeBook)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _recipeBook = recipeBook;
        }

        public void AskForDrink()
        {
            bool flag = true;
            do
            {
                _outputProvider($"Hello please chose what drink you would like {string.Join(", ", _recipeBook.GetAvailableDrinkNames())}");
                _recipeBook.MakeDrink(_inputProvider());
            }
            while (flag);
            
        }
    }
}
