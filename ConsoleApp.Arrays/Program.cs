namespace ConsoleApp.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Arrays ******");

            //Tell me how many students and grades are to be entered
            Console.Write("Please indicate the number of grades to be entered: ");
            int numberOfGrades = Convert.ToInt32(Console.ReadLine());
            //Declare fixed size array
            int[] grades = new int[numberOfGrades];
            string[] students = new string[numberOfGrades];

            //Add values to fixed size array
            //grades[0] = 45;
            //grades[1] = 25;
            //grades[2] = 38;
            //grades[3] = 45;
            //grades[4] = 54;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Enter Grade: ");
            //    grades[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Print values in fixed size array
            //Console.WriteLine("The grades you have entered are: ");
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Enter student name: ");
                students[i] = Console.ReadLine();

                Console.Write("Enter grade: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Print values in variable sized array
            Console.WriteLine("The Students and their grades you have entered are: ");
            for(int i = 0;i < numberOfGrades; i++)
            {
                Console.WriteLine($"{students[i]}: {grades[i]}");
            }
            ////Declare variable sized array
            //string[] studentNames =  { "Newt", "Josh", "Charles" };

            ////Add values to Variable sized array
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.Write("Enter student name: ");
            //    studentNames[i] = Console.ReadLine();
            //}
            ////Print values in variable sized array
            ////In this example it will only allow you to type in 3 names b/c I only have 3 names where I declared the variable
            //Console.WriteLine("The student names you have entered are: ");
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
        }
    }
}