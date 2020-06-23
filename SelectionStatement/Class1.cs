using System;

public class Class1
{
    public Class1()
    {
        string subject = "C#";

        Console.WriteLine = ("What is your favorite school subject");
        string userSubject = Console.ReadLine();

        switch (userSubject)
        {
            case "History":
                Console.WriteLine("History is an excellent subject to learn about the Past!");
                break;
            case "Math":
                Console.WriteLine("Look at you Math Wizard!");
                break;
            case "Science":
                Console.WriteLine("You are the next Alber Einstein!");
                break;
            case "Home Esconomics":
                Console.WriteLine("Can you cook dinner tonight?");
                break;
            case "Physical Education":
                Console.WriteLine("I'm sure you a an excellent athlete");
                break;
            case "Literature":
                Console.WriteLine("Hark! Who goes there?!");
            default:
                Console.WriteLine("Well I guess you don't like school at all");
                break;
        }
    }
}
