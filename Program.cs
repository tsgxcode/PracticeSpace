using System;

namespace PracticeSpace
{
    class Program
    {

        public static void Main()
        {
            //A simple on/off switch, depending on the operator. 
            string a = "Off";
            string b = "On";
            if (a + b != "")
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