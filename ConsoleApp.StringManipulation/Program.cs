namespace ConsoleApp.StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** String manipulation **********");

            //Initialize with a regular string literal.
            string s1 = "This is a literal string"; //literal when developer puts it in
            String s2 = "This is a literal string as well";
            Console.WriteLine($"{nameof(s1)}: {s1}");
            Console.WriteLine($"{nameof(s2)}: {s2}");

            //Declare without initializing. (possible null exception)
            string s3; //default value is null
            //Console.WriteLine(s3);//Syntax error

            //Initialize as an empty string
            string? s4 = null;//? tells us this is nullable
            Console.WriteLine(s4);

            //Initialize as an empty string
            string s5 = string.Empty; //these both mean the same thing, but string.Empty is the preffered way
            string s6 = "";
            Console.WriteLine(s5);
            Console.WriteLine(s6);

            //Escape sequences and characters
            string sentence = "She said, \"I have your phone\" \r\n This is the next line";
            Console.WriteLine(sentence);

            //Verbatim string literal
            string oldpath = "C:\\program files\\programfolder\\";
            string newpath = @"C:\program files\programfolder\";
            Console.WriteLine(oldpath);
            Console.WriteLine(newpath);

            //Use a const string to prevent modification to a string
            //adding const, means we can never accidentally give a new value or modify this string
            const string path = "C:\\program files\\programfolder\\";
            Console.WriteLine(path);

            //Raw string literals
            string rawLiteral = """ She said, "I have your phone" """;
            Console.WriteLine(rawLiteral);

            //If you need multi line string
            string rawLiteral1 = """
                She said, "I have your phone"
                This is the next line.
                And another line
                path = "C:\\program files\\programfolder\\"
                """;
            Console.WriteLine(rawLiteral1);

            //Review concatenation and interpolation
            s1 = s1 + s2; // these are genrally bad practice
            s1 += s2;

            string newstring = $"{s1} + {s2} some random literal text";
            string newstring1 = s1 + $"{s1} + {s2} some random literal text";
            string newstring2 = String.Format("Literal string {0} {1}", s1, s2);

            Console.WriteLine(newstring);
            Console.WriteLine(newstring1);
            Console.WriteLine(newstring2);

            /* String manipulation methods and properties. Sometimes just assesment */

            //Null or empty checks
            //find the length of a string
            Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
            Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
            
           // Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");//Will cause null exception warning - look at squigally lines
           //It's happy in the if statement below.
            if(!string.IsNullOrEmpty( s4 ))
            {
                Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
            }
            if( !string.IsNullOrEmpty( s5 ))
            {
                Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
            }

            //Substrings
            string subString = s1.Substring(5);
            Console.WriteLine($"{nameof(subString)}: {subString}");
            subString = s1.Substring(5, 5);
            Console.WriteLine($"{nameof(subString)}: {subString}");

            //Splitting strings
            var splitStrings = s2.Split(' ');
            for(int i = 0;  i < splitStrings.Length; i++)
            {
                Console.WriteLine($"{splitStrings[i]}");
            }


            //Replace
            string replacements = s1.Replace('s', 'V');
            Console.WriteLine($"{nameof(replacements)}: {replacements}");
            string replacements2 = s1.Replace("string", "chicken");
            Console.WriteLine($"{nameof(replacements2)}: {replacements2}");

            //Convert to string
            string salary = 47896.23.ToString();
            int value = 75500;
            string strValue = value.ToString();
            bool chosen = true;
            chosen.ToString();

            //Changing formatting
            Console.WriteLine($"{nameof(salary)} : {salary:C}");
            Console.WriteLine(nameof(salary) + ": " + value.ToString("C"));


         
        }
    }
}