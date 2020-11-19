using System;
using System.Threading;
namespace Calcy
{

    class Program
    {
        static void Main(string[] args)
        {
            string operator1 = "";
            string operator2 = "";
            string textToEnter = "Calcy";
            float term1 = 0, term2 = 0, term3 = 0;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));


            Console.WriteLine(">\nWelcome to Calcy! \n Please enter operators...");
            Console.Write(">Operator 1:");
            operator1 = Console.ReadLine();
            Console.Write(">Operator 2:");
            operator2 = Console.ReadLine();
            Console.WriteLine(">Now, enter three terms");
            Console.Write(">Term 1: ");
            term1 = float.Parse(Console.ReadLine());
            Console.Write(">Term 2: ");
            term2 = float.Parse(Console.ReadLine());
            Console.Write(">Term 3: ");
            term3 = float.Parse(Console.ReadLine());


        }


    }
}