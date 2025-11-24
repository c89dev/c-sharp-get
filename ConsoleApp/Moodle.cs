using System.Text;
using Christian;

internal class Moodle
{
    public class CharCounter
    {
        public void Count()
        {
            var range = 256;
            var counts = new int[range];
            var total = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToLower() ?? string.Empty)
                {
                    total++;
                    counts[(int)character]++;
                }
                Console.WriteLine("Total is " + total);
                for (
                    var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var percentage = (double)counts[i] / total;
                        var character = (char)i;
                        Console.WriteLine("{0,-4}{1,-4}{2,-4:P2}", character, counts[i], percentage);
                    }
                }
            } 
        }
           
    }
    public class TextTangler
    {
        AsciiArt art = new AsciiArt();
        public void Play()
        {
            Console.Title = "The Text Tangling Jester";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(art.jester);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pick an option!\n"); 
            Console.WriteLine("1. Rotate Text \n2. Change Word");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                {
                    RotateText();
                    break;
                }
                case "2":
                {
                    ChangeVowels();
                    break;
                }
            }

            ;
        }

        public void ChangeVowels()
        {
            var input = MyConsole.AskForText("Type in a word or sentence");
            List<char> inputChars = new List<char>();
            foreach (var c in input)
            {
                if (c == 'e')
                {
                    inputChars.Add('a');
                }
                else if (c == 'E')
                {
                    inputChars.Add('A');
                }
                else
                {
                    inputChars.Add(c);
                }
            }
            for (var i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(art.jesterLaugh);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 20);
                Console.Write(string.Join("", inputChars));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep();
                Thread.Sleep(200);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(0,2);
                Console.WriteLine(art.jesterLaugh2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 20);
                Console.Write(string.Join("", inputChars));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Thread.Sleep(200);
            }

            Console.ReadLine();
        }
        
        public void RotateText()
        {
            var input = MyConsole.AskForText("Type in a word or sentence");
            string inputReverse = ""; 
            for (var c = input.Length - 1; c >= 0; c--)
            {
                inputReverse += input[c];
            }

            for (var i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(art.jesterLaugh);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 20);
                Console.WriteLine(inputReverse);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep();
                Thread.Sleep(200);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(0,2);
                Console.WriteLine(art.jesterLaugh2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 20);
                Console.WriteLine(inputReverse);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Thread.Sleep(200);
            }
            
            Console.ReadLine();
        }
    }
    public class CrocGame
    {
        Random rnd = new Random();
        int score = 0;
        int numA;
        int numB;
        AsciiArt art = new AsciiArt();
        
        public void Play()
        {
            int numA = rnd.Next(0, 11);
            int numB = rnd.Next(0, 11);
            
            Console.Title = "Crocodile Game";
            
            Console.Clear();     
            Console.ForegroundColor= ConsoleColor.Green;
            Console.SetCursorPosition(30, 1);
            Console.WriteLine(art.crocArt);
            Console.SetCursorPosition(54, 5);
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine($"Score: {score}");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("          *CROCODILE GAME*");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\nType the correct operator (<, >, =)");
            Console.WriteLine($"{numA} _ {numB}");
           
            var input = Console.ReadLine();
            
            if (input == "q" || input == "Q" || input == "quit" || input == "exit")
            {
                Console.WriteLine("Quit the program? y/n");
                var answer = Console.ReadKey();
                if (answer.Key == ConsoleKey.Y)
                {
                    Environment.Exit(0);
                }
                else if (answer.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Play(); 
                }
            }
            
            if (input == "=" && numA == numB)
            {
                score++;
            }
            else if (input == "<" && numA < numB)
            {
                score++;
            }
            else if (input == ">" && numA > numB)
            {
                score++;
            }
            else {
                score--;
            }
            ;
            Console.Clear();
            Play();
        }
    }
    public static void Loops()
    {
        int num = 10;
        string[]  args = new string[] {"This",  "is", "a", "test"};
        string yeet = "yeet";
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        foreach (var c in yeet)
        {
            Console.WriteLine(c);
        }

        int round = 0;
        while (round < 10)
        {
            Console.WriteLine($"Round number {round}");
            round++;
        }
        Console.Read();
        
    }
    public static void SwitchExpression()
    {
        Console.WriteLine("Please enter a weekday number");
        var input = int.TryParse(Console.ReadLine(), out var number);
        if (!input)
        {
            SwitchExpression();
        }
        else
        {
            var result = number switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wedensday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Unknown input",
            };

            if (result == "Unknown input")
            {
                SwitchExpression();
            }
            else
            {
                Console.WriteLine($"{result}");
                Console.ReadLine();
            }
        }
    }
    
    public static void SwitchStatement()
    {
        int num = 3;
        switch (num)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
        }
        Console.Read();
    }
    public static void GetAndCheckIfEqual()
    {
        int numA = MyConsole.AskForNumber("Please enter a number");
        int numB = MyConsole.AskForNumber("Please enter a number");
        int added = numA + numB;
        int multiplied = numA * numB;
        
        if (numA == numB)
        {
            Console.WriteLine($"These numbers are equal, and multiplied, they are {multiplied}");
        }
        else {
            Console.WriteLine($"These numbers are NOT equal , and summed, they are {added}");
        }

        Console.Read();
    }
    
    public static bool SumIs30()
    {
        int numA = MyConsole.AskForNumber("Please enter a number");
        int numB = MyConsole.AskForNumber("Please enter a number");
        int sum = numA + numB;
        int multiplied = numA * numB;
        
        if (sum == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int SumOfTwoNum(int a, int b)
    {
        return a + b;
    }
    private static void ReturnOfNothing()
    {
        Console.WriteLine("Returning nothing, but can do something");
    }   
}