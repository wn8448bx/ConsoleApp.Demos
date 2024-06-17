namespace ConsoleApp.ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes the user's age as input and prints to the screen.
            //Display an error message if an invalid input is recieved.
            try
            {
                Console.WriteLine("Please enter your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your age is {userAge}");
            }
            catch (Exception)
            {
                Console.WriteLine("Your age value was incorrect, please try again.");
                //throw; throw ends the program and shows original exception
            }
            finally
            {
                Console.WriteLine("**** Thank you for using this program *****");
            }
            
        }
    }
}