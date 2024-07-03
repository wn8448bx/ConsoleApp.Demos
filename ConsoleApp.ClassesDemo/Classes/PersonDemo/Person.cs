﻿using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo 
{

    //Define a Class
    public partial class Person
    {
        public Person()
        {

        }
        public Person(string firstName, string lastName, string taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            _taxNumber = taxNumber;
        }
        //Need to define Properties/Data Members
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }

        //Field member
        private string _taxNumber;
        protected string _idNumber = "N/A";

        public void PrintFullName()
        {
            var type = GetType().Name;
            Console.WriteLine($"{type} name: {FirstName} {LastName}");
        }

        public void PrintInitials()
        {
            var type = GetType().Name;
            var firstInitial = FirstName[0];
            var lastInitial = LastName[0];
            Console.WriteLine($"{type} initials: {firstInitial}{lastInitial}");
        }

        public void GenerateTaxNumber()
        {
            if (string.IsNullOrEmpty(_taxNumber))
            {
                _taxNumber = GetRandomNumber();
            }
            else
            {
                Console.WriteLine($"A tax number already exists for {FirstName} {LastName}.");
            }

        }
        public string GetTaxNumber()
        {
            return _taxNumber;
        }

        public string GetIdNumber()
        {
            return _idNumber;
        }

       
        protected string GetRandomNumber()
        {
            return RandomNumberGenerator.GetInt32(10000, 99999).ToString();
        }
    }
   
}
