using ConsoleApp.ClassesDemo.Utilities;
using System.Security.Cryptography;
using static ConsoleApp.ClassesDemo.Program;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH");
        }
    }
}
