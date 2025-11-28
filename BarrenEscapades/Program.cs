using ConsoleApp;
namespace BarrenEscapades;

public class Program
{
    static void Main(string[] args)
    {
       // ConsoleCFG();
       StartGame(); 
       
    }

    public static void StartGame()
    {
        Battle.InitFight();
    }

    
    public static void DrawHUD()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 5);
        Console.WriteLine($"Monster HP: [ { monsterHealth } ]");
    }

    public static string RollForWeapon()
    {
        Random rand = new Random();
        int rnd = rand.Next(0, Model.weapons.Length);
        string randWeapon = Model.weapons[rnd];
        RandomQuality(randWeapon);
        return randWeapon;
    }
    
    public static void RandomQuality(string weapon)
    {
        Random rand = new Random();
        int roll = rand.Next(0, 1000); 
            var quality = roll switch 
            {
                <= 150 => "Low ass quality",
                >= 151 and <= 700 => "Medium quality",
                >= 70 and <= 900 => "Good quality",
                > 900 => "Pristine quality",
            };
        Console.WriteLine(weapon);
        Console.WriteLine(roll);
        Console.WriteLine(quality);
    }
    

    static void PullRandomLoot()
    {
        Random rand = new Random();
        int max = Model.loot.Length;
        int pick = rand.Next(0, max); 
        Console.WriteLine("Pulling Random Loot");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("You found: " + Model.loot[pick]);
    }
    public static void AddUserDrawHeader()
    {
        string name = AskForText("What is your name?");
        int age = 2025 - AskForNumber("What is your year of birth?");
       
        Console.WriteLine("Hello " + name +"! " + "You are " + age + " years old.");
        Model.users.Add(new Model.User {name = name, age = age} );
        Console.WriteLine(DrawUI.DrawHeader());
    }
}