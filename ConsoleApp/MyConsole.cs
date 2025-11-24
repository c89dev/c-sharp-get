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
    }
}