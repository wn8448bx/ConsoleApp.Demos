using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Utilities
{
    public static class PersonHelper
    {
        public static string GenerateIdNumber(string prefix)
        {
            var randomNumber = RandomNumberGenerator.GetInt32(10000, 99999).ToString();
            return $"{prefix}-{randomNumber}";
        }
    }
}
