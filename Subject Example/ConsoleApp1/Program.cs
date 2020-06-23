using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var userSubject = Console.ReadLine();


            switch (userSubject)
            {
                case "History":
                    Console.WriteLine("History is an excellent subject to learn about the past!");
                    break;
                case "Math":
                    Console.WriteLine("Look at you...Math Wizard!");
                    break;
                case "Science":
                    Console.WriteLine("You are the next Albert Einstein!");
                    break;
                case "Home Esconomics":
                    Console.WriteLine("Can you cook dinner tonight?");
                    break;
                case "Physical Education":
                    Console.WriteLine("I'm sure you a an excellent athlete");
                    break;
                case "Literature":
                    Console.WriteLine("Hark! Who goes there?!");
                    break;
                default:
                    Console.WriteLine("Well I guess you don't like school at all");
                    break;
            }
        }
    }
}