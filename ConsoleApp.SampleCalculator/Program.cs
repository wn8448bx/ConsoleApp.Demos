namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            int choice = 0;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Welcome to the sample calculator!");
            Console.WriteLine();
            while (choice != -1)
            {
                try
                {
                    //Show Calculator options / show menu
                    Console.WriteLine("Please select an operation by number associated (-1 to exit program)");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Fibonacci sequence");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == -1)
                    { break; }

                    //Prompt for user input
                    Console.Write("Please enter the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

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
                        default:
                            throw new Exception("Invalid menu item selected.");

                    }
                    //print output
                    Console.WriteLine($"The result is: {answer}");
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        
            Console.WriteLine("***** Thank you for using the sample calculator *****");
        }
    }
}
