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
            int i; //to count
            if (userInt % 2 == 1)
            {
                //set inputDetermination to odd
                inputDetermination = "odd";
                printCounter = userInt - 1;
                //for loop that prints statements the amount of times equal to printCounter
                for (i = 1; i <= printCounter; i++)
                {
                    Console.WriteLine(i.ToString() + ". You entered an odd number");
                }
            }
            else
            {
                //set inputDetermination to even
                inputDetermination = "even";
                printCounter = userInt + 1;
                //for loop that prints statements the amount of times equal to printCounter
                for (i = 1; i <= printCounter; i++)
                {
                    Console.WriteLine(i.ToString()+ ". You entered an even number");
                }
            }
        }
    }
}
