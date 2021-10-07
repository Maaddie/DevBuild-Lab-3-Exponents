using System;

namespace DevBuild_Lab3_Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing == true)
            {
                int userNumber;
                int sqNum = 0;
                int cubNum = 0;
                
                Console.WriteLine("Hello! Let's learn how to calculate squares and cubes! ");
                Console.WriteLine("Please input a number: ");
                userNumber = int.Parse(Console.ReadLine());

                for (int i = 1; i <= userNumber; i++)
                {
                    sqNum = i * i;
                    cubNum = i * i * i;

                    Console.Write($"Number {i} \t");
                    Console.Write($"Square number {sqNum} \t");
                    Console.WriteLine($"Cube number {cubNum} \t");
                }

                keepGoing = Continue();
            }
        }
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;
        }
        public static bool Continue()
            {
                string answer = GetInput("Would you like to continue entering numbers? y/n");

                if (answer == "y")
                {
                    return true;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thank you for learning with me! Goodbye!");
                    return false;
                }
                else
                {
                    return Continue();
                }
        
        }
    }
}
