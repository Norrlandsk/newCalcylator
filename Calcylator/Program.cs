using System;
using System.Data;
using System.Collections.Generic;

namespace Calcy
{

    class Program
    {
        static void Main(string[] args)
        {

            string operator1 = "";
            string operator2 = "";
            string choice = "";
            string textToEnter = "Calcy";
            float term1 = 0, term2 = 0, term3 = 0, sum = 0, totSum=0;
            bool isRunning = true;
            List<float> sumList = new List<float>();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));


            Console.WriteLine("\n>Welcome to Calcy! \n Please enter operators...");
            while (isRunning)
            {
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

                if (operator1 == "*")
                {
                    if (operator2 == "*")
                    {
                        sum = term1 * term2 * term3;
                    }
                    else if (operator2 == "/")
                    {
                        sum = term1 * term2 / term3;
                    }
                    else if (operator2 == "+")
                    {
                        sum = term1 * term2 + term3;
                    }
                    else if (operator2 == "-")
                    {
                        sum = term1 * term2 - term3;
                    }
                    else if (operator2 == "%")
                    {
                        sum = term1 * term2 % term3;
                    }

                }

                else if (operator1 == "/")
                {
                    if (operator2 == "*")
                    {
                        sum = term1 / term2 * term3;
                    }
                    else if (operator2 == "/")
                    {
                        sum = term1 / term2 / term3;
                    }
                    else if (operator2 == "+")
                    {
                        sum = term1 / term2 + term3;
                    }
                    else if (operator2 == "-")
                    {
                        sum = term1 / term2 - term3;
                    }
                    else if (operator2 == "%")
                    {
                        sum = term1 / term2 % term3;
                    }


                }

                else if (operator1 == "+")
                {
                    if (operator2 == "*")
                    {
                        sum = term1 + term2 * term3;
                    }
                    else if (operator2 == "/")
                    {
                        sum = term1 + term2 / term3;
                    }
                    else if (operator2 == "+")
                    {
                        sum = term1 + term2 + term3;
                    }
                    else if (operator2 == "-")
                    {
                        sum = term1 + term2 - term3;
                    }
                    else if (operator2 == "%")
                    {
                        sum = term1 + term2 % term3;
                    }


                }

                else if (operator1 == "-")
                {
                    if (operator2 == "*")
                    {
                        sum = term1 - term2 * term3;
                    }
                    else if (operator2 == "/")
                    {
                        sum = term1 - term2 / term3;
                    }
                    else if (operator2 == "+")
                    {
                        sum = term1 - term2 + term3;
                    }
                    else if (operator2 == "-")
                    {
                        sum = term1 - term2 - term3;
                    }
                    else if (operator2 == "%")
                    {
                        sum = term1 - term2 % term3;
                    }

                }

                else if (operator1 == "%")
                {
                    if (operator2 == "*")
                    {
                        sum = term1 % term2 * term3;
                    }
                    else if (operator2 == "/")
                    {
                        sum = term1 % term2 / term3;
                    }
                    else if (operator2 == "+")
                    {
                        sum = term1 % term2 + term3;
                    }
                    else if (operator2 == "-")
                    {
                        sum = term1 % term2 - term3;
                    }
                    else if (operator2 == "%")
                    {
                        sum = term1 % term2 % term3;
                    }
                }



                Console.WriteLine(">"+term1 + operator1 + term2 + operator2 + term3 + "=" + sum);
                sumList.Add(sum);
                if (sum<100)
                {
                    Console.WriteLine(">The result is less than one hundred");
                }
                else if (sum>100)
                {
                    Console.WriteLine(">The result is more than one hundred");
                }
                else 
                    Console.WriteLine(">Cool, the result is exactly one hundred");

                Console.WriteLine(">Wanna go again? (y/n)");
                choice=Console.ReadLine();

                if (choice == "y")
                { Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));


                    Console.WriteLine("\n>Welcome to Calcy! \n Please enter operators...");
                    continue; }
                else if (choice == "n")
                {
                    Console.Clear();
                    for (int i = 0; i <sumList.Count; i++)
                    {
                        totSum += sumList[i];
                        
                        
                    }
                    Console.WriteLine("The sum of all results is: " + totSum);
                    isRunning = false;
                }

            }




            /* 
             {

                 Console.WriteLine("Write an expression with three terms and two operators");
                 var result = new DataTable().Compute(Console.ReadLine(), null);
                 Console.WriteLine("The result of the expression is: "+result);
             }*/

        }





    }

}



