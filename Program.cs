using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Empty variable that will be replaced with string of even or odd
            string inputDetermination = "";
            int printCounter = 0;

            //Asks user to input integer, saves it as userInt
            Console.WriteLine("Please enter an integer value between 2 and 10:");
            int userInt = Int32.Parse(Console.ReadLine());

            //check if input is even or odd
            if (userInt % 2 == 1)
            {
                //set inputDetermination to odd
                inputDetermination = "odd";
                printCounter = userInt - 1;
            }
            else
            {
                //set inputDetermination to even
                inputDetermination = "even";
                printCounter = userInt + 1;
            }

            Console.WriteLine("Your integer is " + inputDetermination + ", will be printed " + printCounter.ToString() + " times.");
        }
    }
}
