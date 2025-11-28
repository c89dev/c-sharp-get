public static class Battle
{
    //Model 
    static bool fightMode = true;
    static bool playerAlive = true;
    static bool monsterAlive = true;
    static bool monsterIsAttacking = false;
    static int playerHealth = 100;
    static int monsterHealth = 2000;
    static int playerLuck = 1;
    static int maxDmg = 720;
    static int minDmg = 50;
        
    //Controller 
    static Random randDmg = new Random();
    private static string inputDirection = null; 
    private static string commandInput = null;

        
    public static void InitFight()
    {
        while (fightMode)
        {
            MonsterAttack();
        }
    }
        
    public static void PlayerAttack()
    {
        int damageAmt = randDmg.Next(minDmg, maxDmg + 1 * playerLuck);
        Console.WriteLine("You attack monster, dealing " + damageAmt + " damage");
        monsterHealth -= damageAmt;
        if (monsterHealth < 1)
        {
            fightMode = false;
                
            Console.WriteLine("Monster is dead");

        }
            
    }
    public static void MonsterAttack()
    {
        Console.WriteLine("Monster hits you, dealing X damage");
        playerHealth -= 30;
            
        if (playerHealth < 1)
        {
            fightMode = false;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU DIED");
        }
    }

}