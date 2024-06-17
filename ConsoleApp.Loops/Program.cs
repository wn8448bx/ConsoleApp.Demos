namespace ConsoleApp.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple for loop demo
            //Print hello world 10 times

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello, World! - {i}");
            }
            Console.WriteLine();

            ////Ask user how many times they wish to brint hello world and print accordingly
            //Console.WriteLine("********** User Input For Loop *********");
            //int howManyTimes = 0;
            //Console.Write("How many times do you want to print Hello, World!: ");
            //howManyTimes = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= howManyTimes; i++) 
            //{
            //    Console.WriteLine($"Hello, World! - {i}");
            //}

            Console.WriteLine();
            Console.WriteLine("********** While Loop *********");

            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine($"Hello, World! - {counter}");
                counter += 2;
            }
            Console.WriteLine();

            //Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit
            Console.WriteLine("********** User Input While Loop *********");
            Console.WriteLine();

            int sum = 0;
            int num = -1;
            
            while(num != -1)
            {
                Console.Write("Enter the number you wish to sum. Type -1 to exit: ");
                num = Convert.ToInt32(Console.ReadLine());
                // nested if statement - an if statement within a code block
                if(num != -1)
                {
                    sum += num;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Your sum is: {sum}");

            Console.WriteLine("********** Do While Loop *********");
            Console.WriteLine();
            sum = 0;
            num = -1;
            do
            {
                Console.Write("Enter the number you wish to sum. Type -1 to exit: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != -1)
                {
                    sum += num;
                }
            } 
            while (num != -1);
            Console.WriteLine();
            Console.WriteLine($"Your sum is: {sum}");


            Console.WriteLine();
            Console.WriteLine("Loop completed!");
        }
    }
}