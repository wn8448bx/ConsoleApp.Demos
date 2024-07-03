using Microsoft.VisualBasic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace ConsoleApp.UserInputDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string firstName = string.Empty; //could leave it string name; - but not best practice 
            string? lastName = string.Empty; //? allows this variable to hold a null value, now the warning is gone from corresponding ReadLine
            //int age = 0;
            char choice = char.MinValue;
            DateOnly dob = new DateOnly();
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = true; //bools will automatically default to false if not stated otherwise

            List<Person> persons = new List<Person>();

            while(choice != 'E')
            {
                //Prompt the user for input
                Console.Write("Please enter your first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter your last name: ");
                lastName = Console.ReadLine();

                Console.Write("Please enter your date of birth (mm/dd/yyy): ");
                dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy", CultureInfo.InvariantCulture);


                Console.Write("Please enter your salary: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Please enter your gender (M or F): ");
                gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Are you working (true or false): ");
                working = Convert.ToBoolean(Console.ReadLine());

                Person person = new(dob)
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    IsWorking = working,
                    Salary = salary
                };
                persons.Add(person);
                Console.WriteLine("C - Continue or E - Exit");
                choice = Convert.ToChar(Console.ReadLine());
            }

           foreach(var person in persons)
            {
                Console.WriteLine();
                //Output the results to the user
                Console.WriteLine($"Full name: {person.ToString()}");
                Console.WriteLine($"Age: {person.GetAge()}");
                Console.WriteLine($"You Gender is: {person.Gender}");
                Console.WriteLine($"Your Salary is: {person.Salary.ToString("C")}");
                Console.WriteLine($"You Are Employed: {person.IsWorking}");
                Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
                Console.WriteLine($"Estimated Retirement year: {person.GetEstimatedRetirementDate()}");
            }

           
        }
    }
}