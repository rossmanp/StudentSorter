using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab6_StudentScores
{
    class Validator
    {
        static int _myInt;

        public Validator()
        {

        }

        //This method confirms that the user entered an integer, and returns the integer.

        public static int getInt(string prompt)
        {
            int.TryParse(prompt, out _myInt);
            while (!int.TryParse(prompt, out _myInt))
            {
                Console.Write("\nThe value must be an integer, try again: ");
                prompt = Console.ReadLine();
            }
            return _myInt;
        }

        //For the user to proceed, he or she must enter an integer within the specified range.

        public static int getIntWithinRange(int min, int max)
        {
            bool run = true;
            Validator num = new Validator();
            while (run)
            {
                _myInt = Validator.getInt(Console.ReadLine());
                if (_myInt < min)
                {
                    Console.WriteLine("\nError! Please enter an integer greater than " + (min - 1));
                }
                else if (_myInt > max)
                {
                    Console.WriteLine("\nError! Please enter an integer less than " + (max + 1));
                }
                else
                {
                    run = false;
                }
            }
            return _myInt;
        }

        public static string getString(string input)
        {
            bool run = true;
            while (run)
            {
                if (String.IsNullOrWhiteSpace(input)) 
                {
                    Console.WriteLine("You did not input a name! Please try again.");
                    return Validator.getString(Console.ReadLine());
                }
                else
                {
                    run = false;
                }
            }
            return input;
        }
    }
}
