using System;
using System.Security.Cryptography.X509Certificates;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int favNumber = 47;

                Console.WriteLine("Guess the favorite number. Hint: Below 50");

                var userInput = int.Parse(Console.ReadLine());


                if (userInput < favNumber)
                {
                    Console.WriteLine($"Too Low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Too High");
                }
                else if (userInput == favNumber)

                {
                    Console.WriteLine($"You are Correct!!");
                }
                else
                {
                    Console.WriteLine($"Nevermind");
                }

        
                }
            }
        }
    }