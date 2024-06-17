namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sample calculator!");

            //Show Calculator options / show menu
            Console.WriteLine("Please select an operation by number associated (-1 to exit program)");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Fibonacci sequence");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while(choice != -1)
            {
                //Prompt for user input
                Console.Write("Please enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                //Decide which operator is needed based on selected option
                int answer = 0;
                switch (choice)
                {
                    case 1:
                        answer = num1 + num2;
                        break;
                    case 2:
                        answer = num1 - num2;
                        break;
                    case 3:
                        answer = num1 * num2;
                        break;
                    case 4:
                        answer = num1 / num2;
                        break;
                    case 5:
                        for (int i = num1; i <= num2; i++)
                        {
                            answer += i;
                        }
                        break;

                    defualt:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                //print output
                Console.WriteLine($"The result is: {answer}");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Please select an operation by number associated (-1 to exit program)");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Fibonacci sequence");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("***** Thank you for using the sample calculator *****");
        }
    }
}