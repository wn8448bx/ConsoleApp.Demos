namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string firstName = string.Empty; //could leave it string name; - but not best practice 
            string? lastName = string.Empty; //? allows this variable to hold a null value, now the warning is gone from corresponding ReadLine
            int age = 0;
            int retirementAge = 65;
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = true; //bools will automatically default to false if not stated otherwise

            //Prompt the user for input
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M or F): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working status (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            //Process the data
            int workingYearsRemaining = retirementAge - age;

            //Output the results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"You Gender is: {gender}");
            Console.WriteLine($"Your Salary is: {salary}");
            Console.WriteLine($"You Are Employed: {working}");
            Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");

        
        }
    }
}