namespace Christian
{
    public class MyConsole
    {
        public static string AskForText(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static int AskForNumber(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        // public static void Write(string text, int col, int row,
        //     ConsoleColor textColor, ConsoleColor backColor)
        // {
        //    Console.BackgroundColor = backColor;
        //    Console.ForegroundColor = textColor;
        //    Console.SetCursorPosition(col, row);
        //    Console.Write(text);
        // }
        public static void Write(int col, int row, params string[] texts)
        {
            for (var i = 0; i < texts.Length; i++)
            {
                Write(texts[i], col, row + i);
            }
        }

        public static void Write(string text, int col, int row,
            ConsoleColor foreColor = ConsoleColor.White,
            ConsoleColor backColor = ConsoleColor.DarkBlue
        )
        {
            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.BackgroundColor = originalBackgroundColor;
            Console.ForegroundColor = originalForegroundColor;
        }
    }
}