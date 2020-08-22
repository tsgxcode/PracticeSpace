using System;

namespace PracticeSpace
{
    class Program
    {

        public static void Main()
        {
            //A simple on/off switch, depending on the operator. the == truns the switch on.
            string a = "Off";
            string b = "On";
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