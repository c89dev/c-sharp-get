using System;
using System.Text;
using System.IO;
using Christian;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var box = new Moodle.DrawBox();
            box.Run(82, 135);
            Console.ReadLine();

            // var guessTheNumber = new Moodle.GuessTheNumber();
            // guessTheNumber.Init();
            // var charCounter = new Moodle.CharCounter();
            // charCounter.Run();
            // var textTangler = new Moodle.TextTangler();
            // textTangler.Run();
            // var crocGame = new Moodle.CrocGame();
            // crocGame.Run();


        }
    }
}