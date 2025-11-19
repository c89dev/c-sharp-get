using System.Reflection.Metadata;
using System.Xml.Schema;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        
       string name = AskForText("What is your name?");
       int age = 2025 - AskForNumber("What is your year of birth?");
       
       Console.WriteLine("Hello " + name +"! " + "You are " + age + " years old.");
       Model.users.Add(new Model.User {name = name, age = age} );
       Console.WriteLine(DrawUI.DrawHeader());
       Console.Read();
       
    }

    private static string AskForText(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
    }
    private static int AskForNumber(string question)
    {
       Console.WriteLine(question);
       return int.Parse(Console.ReadLine());
    }
}