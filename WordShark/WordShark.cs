using Christian;
using System.Timers;
using Timer = System.Timers.Timer;

public class WordShark
{
    private Model model = new Model();
    private static Timer aTimer;
    readonly static object locker = new object();

    public void Run()
    {
        aTimer = new System.Timers.Timer();
        aTimer.Interval = 2000;
        aTimer.Enabled = true;
        // Thread inputTask = new Thread(ListenForInput);
        // inputTask.Start();
        FishSpawner();
        aTimer.Elapsed += TimedEvent;
        

        while (true)
        {
            Console.CursorVisible = false;
            Console.Clear();
            lock (locker)
            {
                // for (var i = model.ActiveFish.Count; i < model.ActiveFish.Count; i++)
                foreach (var fish in model.ActiveFish)
                {
                    Write(fish);
                    Update(fish);
                }
            }
            Thread.Sleep(100);
        }
    }

    public void TimedEvent(Object source, ElapsedEventArgs e)
    {
       FishSpawner(); 
    }

    public void FishSpawner()
    {
        lock (locker)
        {
            var gameObject = new Model.GameObject
            {
                Col = 6,
                Row = RandomNum(),
                ColSpeed = 1,
                Text = model.Words[RandomNum()],
                TextColor = ConsoleColor.Cyan,
                BackColor = ConsoleColor.DarkBlue,
            };
            {
                model.ActiveFish.Add(gameObject);
            }
        }

    }
    public static int RandomNum()
    {
        Random random = new Random();
        int number = random.Next(0, 6);
        return number;
    }

    // public void ListenForInput()
    // {
    //     var input = Console.ReadLine();
    //     lock (locker)
    //     {
    //         foreach (var fish in model.ActiveFish)
    //         {
    //             if (fish.Text.Contains(input))
    //             {
    //                 model.ActiveFish.Remove(fish);
    //             }
    //             else
    //             {
    //                 ListenForInput();
    //             }
    //         }
    //     }
    // }

    public void Write(Model.GameObject gameObject)
    {
        if (gameObject.Col >= 0)
        {
            MyConsole.Write(gameObject.Text, gameObject.Col,
            gameObject.Row, gameObject.TextColor, gameObject.BackColor);
        }
    }

    public void Update(Model.GameObject gameObject)
    {
        gameObject.Col += gameObject.ColSpeed;
        if (gameObject.Col >= Console.BufferWidth - 5)
        {
           gameObject.Col = Console.BufferWidth - 5;
           // gameObject.ColSpeed = -gameObject.ColSpeed;
           Console.Clear();
           Console.SetBufferSize(Console.BufferWidth, 50);
           Console.SetCursorPosition(Console.BufferWidth / 2, Console.BufferHeight / 4);
           MyConsole.AskForText("GAME OVER");

        }
    }
}
