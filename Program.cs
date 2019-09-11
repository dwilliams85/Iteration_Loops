using System;

namespace Iteration_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                for (int i = 1; i <= value_of_input; i++)
                {
                    Console.WriteLine("You Have" + " " + i.ToString() +" "+ "years of experience.");
                }

                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            
        }
    }
}
