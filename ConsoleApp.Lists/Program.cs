namespace ConsoleApp.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Lists ******");

            //Declare a List
            List<int> grades = new List<int>();
            List<string> students = new List<string>();
            int grade = 0;
            string name;
            int gradeCount = 0;
            int @continue; //continue is a keyword, but a perfect name for this variable. Use @ to negate the keyword
            //two other ways to declare a list
            //var grades = new List<int>(); 
            //List<int> grades = new();

            //Add values to list
            //grades.Add(45);
            //Console.WriteLine(grades[0]);
            do
            {
                gradeCount += 1;
                Console.Write("Enter student name: ");
                name = Console.ReadLine();
                students.Add(name);

                Console.Write("Enter Grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if(grade != -1)
                {
                    grades.Add(grade);
                }

                Console.WriteLine("Do you wish to continue? (1 = yes & 2 = no): ");
                @continue = Convert.ToInt32(Console.ReadLine());
            }
            while (@continue == 1);

            //Print values in list - for loop
            Console.WriteLine("The Students and their grades you have entered are: ");
            for (int i = 0; i < gradeCount; i++) 
            {
                Console.WriteLine($"{students[i]}: {grades[i]}");
            }
            //Console.WriteLine("Printing grades via a for loop");
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            //Print values in list - foreach loop
            //Console.WriteLine("Printing grades via a foreach loop");
            //foreach (int g in grades)
            //{
            //    Console.WriteLine(g);
            //}

        }
    }
}