using System;
namespace dle_StockholdSyndrome
{
    public class ChoiceMaking
    {
        public static string Choice(string optionA, string optionB, string prompt)
        {
            string choice = " ";

            //first prompt
            Console.WriteLine(prompt + "\n");
            Console.WriteLine("A. " + optionA + "\nB. " + optionB);
            choice = Console.ReadLine().ToUpper();
            //error checker
            while (ValidChoice(choice))
            {
                Console.WriteLine("\nYour choice was invalid. Please enter again");
                choice = Console.ReadLine().ToUpper();
            }

            //checking for answer
            if (choice == "A")
            {
                Console.WriteLine("You chose" + optionA);
                choice = optionA;
            }
            else if (choice == "B")
            {
                Console.WriteLine("You chose" + optionB);
                choice = optionB;
            }

            return choice;
        }

        //error checker function
        static bool ValidChoice(string choiceEval)
        {
            bool returnValue = false;

            if (choiceEval.ToUpper() != "A" || choiceEval != "B")
            {
                returnValue = true;
            }

            if (choiceEval.ToUpper() == "A" || choiceEval == "B")
            {
                returnValue = false;
            }

            return returnValue;
        }

        public ChoiceMaking(string optionA, string optionB)
        {
            
        }
    }
}
