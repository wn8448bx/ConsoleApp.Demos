namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two different ways to do the same thing, neither is wrong
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = 0;
            Console.Write("Please enter the second number: ");
            string numberEntered = (Console.ReadLine());
            num2 = Convert.ToInt32(numberEntered);
            /*
             Math Operators
            */

            //Add numbers
            int sum = num1 + num2;
            //multiply
            int product = num1 * num2;
            //division
            int qoutient = num1 / num2;
            //Subtraction
            int diffenrece = num1 - num2;
            //modulus
            int mod = num1 % num2;

            Console.WriteLine("----------- Math Results ----------");
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {diffenrece}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Qoutient: {qoutient}");
            Console.WriteLine($"Modulus: {mod}");

            /*
             Logic Operators
            */

            var isGreaterThan = num1 > num2; 
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNotEqualTo = num1 != num2;

            Console.WriteLine();
            Console.WriteLine("---------- Logic Results ----------");
            Console.WriteLine();
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Equal: {isEqualTo}");
            Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Not Equal: {isNotEqualTo}");

            /*
             Assignment Operators
             */

            //int randomValue = 5;
            //int increaseValue = num1 + 5;
            //num1 = num1 + 5; Long hand

            Console.WriteLine("Please enter a random value for assignment operations: ");
            int randomValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------- Assignment Results ----------");
            Console.WriteLine();
            //num1 += 5; //Short hand
            num1 += randomValue; //Short hand
            Console.WriteLine($"Number 1 increased by {randomValue}: {num1}");
            //num1 -= 3;
            num1 -= randomValue;
            Console.WriteLine($"Number 1 decreased by {randomValue}: {num1}");
            //num1 /= 2;
            num1 /= randomValue;
            Console.WriteLine($"Number 1 divided by {randomValue}: {num1}");
            //num1 %= 2;
            num1 %= randomValue;
            Console.WriteLine($"Number 1 modulus by {randomValue}: {num1}");
            //num1 *= 10;
            num1 *= randomValue;
            Console.WriteLine($"Number 1 multiplied by {randomValue}: {num1}");





        }

    }
}