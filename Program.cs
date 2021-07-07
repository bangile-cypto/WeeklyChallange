using System;
using System.Linq;

namespace WeeklyChallange
{
    class Program
    {
        static void Main(string[] args)
        {

            int countedWords = 0, count = 0; 

            Console.WriteLine("Please enter a string\n");
            string inputString = Console.ReadLine();


            countedWords = inputString.Split(' ').Length;
            Console.WriteLine("\nOur string is: " + inputString + "\n");
            Console.WriteLine("WORDCOUNT: " + countedWords);

            string numbers = "123432";
            int digitsCount = numbers.Count(c => char.IsDigit(c));
            Console.WriteLine("NUMBERS: " + digitsCount);


            foreach (char c in inputString) 
            {

                if (Char.IsUpper(c))

                    count++;
            }
            Console.WriteLine("CHARS" + inputString.Length);
            Console.WriteLine("UPPER CASE LETTERS: " + count);
            Console.ReadLine();

            Console.ReadLine();



        }
    }
}


/* string randomText = "String = This is a random string @ my Weekly Challange";
// string greet = "Hello World! ";
 int numbers = 12345;
 char group = 'C';
 bool answers = randomText.Contains("This is a random string @ my Weekly Challange");

 string[] greet = { "bangile","mahlamvu", };
 foreach (var index in greet) {

     greet.Count();
 }
 */

// string greet = "Hello World";
// Console.WriteLine and{greet.Count().ToUpper()" );
//       Console.WriteLine(greet.ToUpper() + randomText.ToLower() + " " + numbers + " " +"For you in group "+ group);
//         Console.WriteLine("Does our String contain lowercase"+answers);


