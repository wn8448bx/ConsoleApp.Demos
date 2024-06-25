namespace ConsoleApp.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Methods ********");

            //void methods - complete a task without returning a value - it's going to do something and finish
            // like - Console.WriteLine();
            // A function/method should do one thing and do it well.
            void PrintName() 
            {
                Console.WriteLine("Charles Klepperich");
            }

            //value returning methods - returns a value after an operation - What do I want it to return and as what datatype
            //Like Console.ReadLine();
            int GetFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }

            //methods with parameters- represent data being passed into a method.
            void PrintNameWithParams(string name)
            {
                Console.WriteLine("Your name is: " + name);
            }

            int GetYearDifferneceWithParams(int year)
            {
                int yearDifference = DateTime.Now.Year - year;
                return yearDifference;
            }
            //methods with optional parameters - parameter is not required...also has a default value
            int GetFutureOrPastYear(int numberofYears = 0) //adding the == 0 adds a fallback if no one enters a year
            {
                var year = DateTime.Now.AddYears(numberofYears).Year;
                return year;
            }


            //methods with nullable parameters
            void PrintNameNullableParam(string? name, int? count)
            {
                //if(string.IsNullOrEmpty(name))
                //{
                //    name = "Defualt Name";
                //}
                //short hand for above - ?? says check to see if the value of the variable to the right is null if it is
                //assign (=) the following value
                name ??= "Defualt Value";
                //if(!count.HasValue)
                //{
                //    count = 1;
                //}
                count ??= 1;

                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(name);
                }

            }

            /* Function Calls */
            //PrintName();
            //int fiveYearsAgo = GetFiveYearsAgo();
            //Console.WriteLine("Five years ago was: " +  fiveYearsAgo);

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //PrintNameWithParams(name);

            //Console.WriteLine("Enter a year");
            //int pastYear = Convert.ToInt32(Console.ReadLine());
            //int yearsAgo = GetYearDifferneceWithParams(pastYear);
            //Console.WriteLine("This was " + yearsAgo + " years ago");


            //Console.WriteLine("Enter a number of years in the future or past");
            //int numberOfYears = Convert.ToInt32(Console.ReadLine());
            //var pastYear1 = GetFutureOrPastYear();
            //Console.WriteLine("The year is: " + pastYear1);

            //var pastYear2 = GetFutureOrPastYear(numberOfYears);
            //Console.WriteLine("The year is: " + pastYear2);

            PrintNameNullableParam(null, null);
            PrintNameNullableParam("Chester", 5);

        }
    }
}