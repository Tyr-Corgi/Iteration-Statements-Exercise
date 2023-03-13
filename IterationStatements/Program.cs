using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {

        static void Main(string[] args)
        {
            MultiTable();
        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumberSelection()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountBy3()
        {
            for (var i = 3; i <= 999; i += 3)
                Console.WriteLine(i);
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualTo(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are NOT equal");

            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is neither");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge()
        {
            bool Age;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");
                Age = int.TryParse(Console.ReadLine(), out result);
            } while (!Age);

            if (result < 18)
            {
                Console.WriteLine($"You need to be 18 to vote");
            }
            else
            {
                Console.WriteLine($"You can vote");
            }

        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void  InRange()
        {
            bool userInput;
            int result;

            do
            {
                Console.WriteLine("Type a Number");
                userInput = int.TryParse(Console.ReadLine(),out result);
            } while (!userInput);

            if (result >= -10 && result <=10)
            {
                Console.WriteLine($"{result} is between -10 and 10");
            }
            else
            {
                Console.WriteLine("${Result} is not between -10 amd 10");
            }
        }
        //Heatin Up Section:

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter a number or integer");
                cont = int.TryParse(Console.ReadLine(), out userInput);
                if (!cont)
                {
                    Console.WriteLine("Invalid Input. Please type a number or interger");
                }
            } while (!cont);

            for (var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }
    }
}

