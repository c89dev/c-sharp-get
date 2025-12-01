using System;
using System.Threading;
namespace Scratchpad;

class Sample
{
    public static void Main()
    {
        ConsoleKeyInfo cki;
        
        do {
            Console.WriteLine("\nPress a key to display; press the 'x' key to quit.");
        
            // Your code could perform some useful task in the following loop. However,
            // for the sake of this example we'll merely pause for a quarter second.
        
            while (!Console.KeyAvailable)
                Thread.Sleep(250); // Loop until input is entered.
        
            cki = Console.ReadKey(true);
            Console.WriteLine("You pressed the '{0}' key.", cki.Key);
            ScratchModel.InputChars.Add((char)cki.Key);
            foreach (var c in ScratchModel.InputChars)
            {
                // Console.WriteLine($"List contains:  {c}");
                Console.Write(c);
            }
        } while(cki.Key != ConsoleKey.Enter);
        string wordString = string.Concat(ScratchModel.InputChars);
        Console.WriteLine(wordString);
        Console.ReadLine();
        
    }
}