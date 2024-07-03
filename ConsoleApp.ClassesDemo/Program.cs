using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.ClassesDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Classes and Objects **********");

            //Define an object of type Person
            Person person; //this will be null by default

            Person baby = new Person();
            baby.LastName = "Thompson";
            baby.FirstName = "Theresa";
            baby.DateOfBirth = new DateOnly(2023, 10, 23);

            Console.WriteLine($"{baby.FirstName} {baby.LastName}");

            baby.PrintFullName();
            baby.PrintInitials();
            baby.GenerateTaxNumber();

            var taxNumber = baby.GetTaxNumber();
            Console.WriteLine(taxNumber);

            var person1 = new Person("Charles", "Klepperich", new DateOnly(1978, 03, 09));
            person1.PrintFullName();
            person1.PrintInitials();

            var person2 = new Person("John", "Doe", "1234567");
            person2.PrintFullName();
            person2.PrintInitials();
            person2.GenerateTaxNumber();
            var person2IdNumber = person2.GetIdNumber();
            Console.WriteLine(person2IdNumber);

            var teacher = new Teacher();
            teacher.LastName = "Tutone";
            teacher.FirstName = "Tommy";
            teacher.DateOfBirth = new DateOnly(1964, 11, 29);

            teacher.PrintFullName();
            teacher.PrintInitials();
            teacher.GenerateTaxNumber();
            teacher.GenerateTeacherIdNumber();
            var teacherTaxNumber = teacher.GetTaxNumber();
            Console.WriteLine(teacherTaxNumber);


            var teacherIdNumber = teacher.GetIdNumber();
            Console.WriteLine(teacherIdNumber);

            Student student = new();
            student.LastName = "Fladstone";
            student.FirstName = "Borris";
            student.DateOfBirth = new DateOnly(2010, 04, 15);

            student.PrintFullName();
            student.PrintInitials();
            student.GenerateTaxNumber();
            student.GenerateStudentIdNumber();

            var studentIdNumber = student.GetIdNumber();
            Console.WriteLine(studentIdNumber);

            //Polygon polygon = new Polygon(); //Compiler error
            Rectangle rectangle = new(10, 20);
            var rectangleArea = rectangle.Area();
            Console.WriteLine($"Area of the rectangle: {rectangleArea}");

            Square square = new(50);
            var squareArea = square.Area();
            Console.WriteLine($"Area of the square: {squareArea}");

            Cuboid cuboid = new(1, 5, 7);
            var cuboidArea = cuboid.Area();
            var cuboidVolume = cuboid.Volume();
            var cuboidPerimeter = cuboid.Perimeter();
            Console.WriteLine($"Cuboid area is: {cuboidArea}");
            Console.WriteLine($"Cuboid volume is: {cuboidVolume}");
            Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");

            Sphere sphere = new(7);
            var sphereVolume = sphere.Volume();
            var sphereCircumference = sphere.Circumference();
            Console.WriteLine($"Sphere volume is: {sphereVolume}");
            Console.WriteLine($"Sphere circumference is: {sphereCircumference}");

        }
    }
}