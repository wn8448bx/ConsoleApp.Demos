namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sample calculator!");

            //Show Calculator options / show menu
            Console.WriteLine("Please select an operation by number associated");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Prompt for user input
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Decide which operator is needed based on selected option
            int answer = 0;
            if (choice == 1)
            {
                answer = num1 + num2;
                
            }
            else if (choice == 2)
            {
                answer = num1 - num2;
                
            }
            else if(choice == 3)
            {
                answer = num1 * num2;
            }
            else if (choice == 4)
            {
               answer = num1 / num2;
            }
            else
            {
                Console.WriteLine("Not a valid option");
            }
            //print output
            Console.WriteLine($"The result is: {answer}");
        }
    }
}