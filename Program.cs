using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                {
                    int sqrt, cube; // declaring variables

                    Console.WriteLine("enter number"); // asking user input
                    
                    int userInput = int.Parse(Console.ReadLine()); // parsing string into int and reading the console and saving it to the variable userInput

                    Console.WriteLine("\tNumber\tSquared\tCubed"); // writing tabbed line for the display table

                    Console.WriteLine("\t*******\t*******\t*******"); // writing tabbed astrisks

                    for (int i = 1; i <= userInput; i++) // using for loop 
                    {
                        sqrt = i * i; // calculating square  
                        
                        cube = i * i * i; // calculating cube

                        Console.WriteLine("\t {0}\t{1}\t {2}", i, sqrt, cube); // displaying out put
                    }
                    

                    Console.WriteLine(" Do you want to continue?, 'y/n'"); // asking user input

                    string asnwer = Console.ReadLine().ToLower(); // reading from the console and converting user input into lower case

                    if (asnwer == "y")
                    {
                    }
                    else
                    {
                        break; // exit the program
                    }
                }
            }
        }
    }
}
