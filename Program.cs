using System;
using System.IO;

namespace PracticeSpace
{
    class Program
    {
        public static string FullText { get; set; }

        public static void Main()
        {
            //C# Practice Space: 

            //Basic if/ else. A simple on/off switch, depending on the operator. the == truns the switch on.
            string a = "Off";
            string b = "On";
            string fullText = $"{a}.{b}.";
            File.AppendAllText(@"C:\Users\TSG\source\repos\PracticeSpace\Data.txt", FullText + Environment.NewLine);

            if (a + b != "On or Off? ")
            {
                Console.WriteLine("Off");
            }
            else
            {
                Console.WriteLine("On ");
            }

        }
    }
}