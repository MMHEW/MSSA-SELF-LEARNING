using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_out_new_concepts
{
    class Tutor
    {

        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        private readonly funMath _subjects; //allows us to hold the dictionary passed from the main class from the funMath class
        
        public Tutor(Func<string> inputProvider, Action<string> outputProvider, funMath subjects)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _subjects = subjects;
        }

        public void AskForHelp()
        {
            bool flag = true;
            do
            {
                try
                {
                    //prints all keys from the _subjects dictionary from funMath class seperated by commas
                    _outputProvider($"Hello what would you like to learn? {string.Join(", ", _subjects.getAvailableSubjects())}"); 
                    //takes input from the user, makes it all lowercase and attempts to pass it back to the funMath class via the teachMe method.
                    _subjects.teachMe(_inputProvider().ToLower());
                }
                //catches all exceptions, only known exception is the user inputting an invalid response
                catch (Exception)
                {
                    _outputProvider("Im sorry but that it not a valid option...please try again\n\n(Press enter to continue)");
                    _inputProvider();
                    Console.Clear();
                }
            }
            
            //keeps this looped
            while (flag);

        }

    }
}
