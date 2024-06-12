namespace ConsoleAppVariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Different Datatypes
            /*
                text - string
                integers - int
                decimal - double, float, decimal
                locigal - bool
            */

            //the following lines are repition, so a variable would be great
            Console.WriteLine("I am Charles Klepperich"); 
            Console.WriteLine("They call me Charles Klepperich");
            Console.WriteLine("My given name is Charles Klepperich");

            string name = "Charles Klepperich";
            Console.WriteLine(name);
            Console.WriteLine("I am " + name); //String concatenation
            Console.WriteLine($"They call me {name}"); //String interpolation
            Console.WriteLine("I was given the name {0}", name); //Formatted string
            Console.WriteLine();

            int age = 46;
            int retirementYearsLeft = 20;
            int retirementAge = age + retirementYearsLeft;

            Console.WriteLine("My age is: " + age);
            Console.WriteLine("My retirement age is: " + retirementAge);

            bool isRetired = false; //when using bool, it is best practice to name variable like a question (isSomething)
            Console.WriteLine("Am I retired? " + isRetired );

        }
    }
}