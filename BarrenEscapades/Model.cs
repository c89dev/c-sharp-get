namespace BarrenEscapades;
public class Model
{
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    public static List<User> users = new List<User>();
    public static string[] loot =
    {
        "Old Boots", 
        "Level 5 Leather Belt", 
        "Cobweb", 
        "Gold Coin", 
        "Rusty Spoon"
    };
    public static string[] weapons =
    {
        "Knife", 
        "Axe", 
        "Chainsaw", 
        "Crochet Needle", 
        "Gatlin Gun"
    };
}
