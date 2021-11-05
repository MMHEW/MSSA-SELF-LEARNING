using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_out_new_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var recipeBook = new RecipeBook(Console.ReadLine, Console.WriteLine);
            var bartender = new bartender(Console.ReadLine, Console.WriteLine, recipeBook);

            bartender.AskForDrink();

            Console.ReadKey();
        }

    }
}
