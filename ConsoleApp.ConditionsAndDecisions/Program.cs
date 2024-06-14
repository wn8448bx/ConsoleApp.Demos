namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt for input
            Console.Write("Please enter the student's grade: ");
            //grade is a global variable or has global scope
            int grade = Convert.ToInt32(Console.ReadLine());

            //Simple If...Else...statement - Decide to print pass or fail based on input
            Console.WriteLine("********** Simple If Results **********");
            if(grade > 50)
            {
                Console.WriteLine("The student passed");
            }
            else
            {
                Console.WriteLine("The student has failled");
                Console.WriteLine("Please refer student to Tutoring Services");
            }
            Console.WriteLine();

            /*
                    * A: 90 - 100
                    * B: 80 - 89
                    * C: 75 - 79
                    * C-: 70 - 74
                    * D: 60 - 69
                    * D-: 50 - 59
                    * F: Less Than 50 X
                    */

            //Complex If...Else...If statement - Decide to print letter based on grade value
            Console.Write("********** Complex If...Else...If Results **********");
            Console.WriteLine();
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("This is not a legitimate value");
                int gradeAfterBonus = grade + 10; //this only lives in this small block of code, cannot be used outside of the next curly brace
                //This is part of garbage collection, its forgotten and relaeses from memory. 
            }
            else if(grade < 50)
            {
                Console.WriteLine("Student has falied - F");
            }
            else if(grade >= 50 && grade <=59)
            {
                Console.WriteLine("D-");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("D");
            }
            else if(grade >= 70 && grade <= 79)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("B");
            }
            else 
            {
                Console.WriteLine("A");
            }
           
            Console.WriteLine();

            //Ternary operator - Used to assign value to a variable based on a condition
            Console.Write("********** Ternary Operator Result **********");
            Console.WriteLine();
            string passStatus = grade < 50 ? "Fail" : "Pass";
            Console.WriteLine($"Your student grade status: {passStatus}");
            Console.WriteLine();

            //Switch Statements - Used to evaluate a value and take an action
            Console.Write("********** Switch Statement Results **********");
            Console.WriteLine();
            /*
             * Write a program to accept an integer as the day of the week and print the apporpriate message as outlined below.
             *1 - Sunday
             *2 - Monday
             *3 - Tuesday
             *4 - Wednesday (Hump Day!)
             *5 - Thursday
             *6 - Friday (TGIF!!)
             *7 - Saturday
            */
            Console.Write("Please enter a number 1 - 7, to get the corresponding day of the week: ");
            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine($"Day {dayOfTheWeek} is Sunday");
                    break;
                case 2:
                    Console.WriteLine($"Day {dayOfTheWeek} is Monday");
                    break;
                case 3:
                    Console.WriteLine($"Day {dayOfTheWeek} is Tuesday");
                    break;
                case 4:
                    Console.WriteLine($"Day {dayOfTheWeek} is Wenesday (Hump Day!)");
                    break;
                case 5:
                    Console.WriteLine($"Day {dayOfTheWeek} is Thursday");
                    break;
                case 6:
                    Console.WriteLine($"Day {dayOfTheWeek} is Friday (TGIF!!)");
                    break;
                case 7:
                    Console.WriteLine($"Day {dayOfTheWeek} is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number entered");
                    break; 
            }

// Switch statement written in If Else If statement, either works, use what you prefer

            //if (dayOfTheWeek > 7 || dayOfTheWeek < 1)
            //{
            //    Console.WriteLine("Your number is not between 1 and 7");
            //}
            //else if (dayOfTheWeek == 1)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Sunday");
            //}
            //else if (dayOfTheWeek == 2)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Monday");
            //}
            //else if (dayOfTheWeek == 3)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Tuesday");
            //}
            //else if (dayOfTheWeek == 4)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Wenesday (Hump Day!)");
            //}
            //else if (dayOfTheWeek == 5)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Thursday");
            //}
            //else if (dayOfTheWeek == 6)
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Friday (TGIF!!)");
            //}
            //else 
            //{
            //    Console.WriteLine($"Day {dayOfTheWeek} is Saturday");
            //}

            Console.WriteLine();
            Console.WriteLine("Thank you for using this program.");
        }
       
    }
}