using System;
using System.Collections.Generic;

namespace Calcy
{

    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string operator1 = "";
            string operator2 = "";
            string choice = "";
            string textToEnter = "Calcy";
            float term1 = 0, term2 = 0, term3 = 0, sum = 0, totSum = 0;
            bool isRunning = true;
            List<float> sumList = new List<float>();


            //Setting title in console
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.WriteLine("\n>Welcome to Calcy! \n>Please enter operators...");


            //Initiating program with while loop
            while (isRunning)
            {

                //Prompting user with variables to be used, two operators and three terms
                Console.Write(">Operator 1:");
                operator1 = Console.ReadLine();
                Console.Write(">Operator 2:");
                operator2 = Console.ReadLine();
                Console.WriteLine(">Now, enter three terms...");
                Console.Write(">Term 1: ");
                term1 = float.Parse(Console.ReadLine());
                Console.Write(">Term 2: ");
                term2 = float.Parse(Console.ReadLine());
                Console.Write(">Term 3: ");
                term3 = float.Parse(Console.ReadLine());


                //Algorithm for deciding which operators to use in which order
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


                //Displaying result and saving the result in a List
                Console.WriteLine(">" + term1 + operator1 + term2 + operator2 + term3 + "=" + sum);
                sumList.Add(sum);


                //Deciding which message to display to user depending on size of result
                if (sum < 100)
                {
                    Console.WriteLine(">The result is less than one hundred");
                }
                else if (sum > 100)
                {
                    Console.WriteLine(">The result is more than one hundred");
                }
                else
                    Console.WriteLine(">Cool, the result is exactly one hundred");



                //Prompting user about whether to repeat program or quit
                Console.WriteLine(">Wanna go again? (y/n)");
                choice = Console.ReadLine();



                //If user enters "y", go to top of while loop
                if (choice == "y")
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                    Console.WriteLine(">Please enter operators...");

                }


                //If user enters "n", iterate through sumList, add the elements and display to user. Bool for while loop is set to false and the program terminates
                else if (choice == "n")
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                    for (int i = 0; i < sumList.Count; i++)
                    {
                        totSum += sumList[i];


                    }
                    Console.WriteLine(">The sum of all results is: " + totSum + "\n>The application is shutting down...");
                    isRunning = false;
                }

            }

        }

    }

}



