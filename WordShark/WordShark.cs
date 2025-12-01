using Christian;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

public class WordShark
{
    private Model model = new Model();
    private static Timer aTimer;
    object lockThis = new object();

    public void Run()
    {
        Console.Title = "Word Shark";
        Console.SetBufferSize(120, 40);
        Console.SetWindowSize(Console.BufferWidth, Console.BufferHeight);
        aTimer = new System.Timers.Timer();
        aTimer.Interval = 2000;
        aTimer.Enabled = true;
        FishSpawner();
        aTimer.Elapsed += TimedEvent;
        ConsoleKeyInfo cki = default(ConsoleKeyInfo);
        string inputString = String.Empty;
        Model.GameObject target = null;

        while (!model.gameOver)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            {
                foreach (var fish in model.ActiveFish)
                {
                    Write(fish);
                    Update(fish);
                }
            }

            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true);
                if (cki.Key != ConsoleKey.Enter)
                {
                    Model.InputChars.Add(cki.KeyChar);
                }
            }

            if (cki.Key == ConsoleKey.Enter)
            {
                cki = default(ConsoleKeyInfo);
                inputString = string.Concat(Model.InputChars);
                lock (lockThis)
                {
                    foreach (var fish in model.ActiveFish)
                    {
                        if (fish.Text.ToLower() == inputString.ToLower())
                        {
                            target = fish;
                        }
                    }
                }

                if (target != null)
                {
                    model.ActiveFish.Remove(target);
                    inputString = String.Empty;
                    Model.InputChars.Clear();
                    target = null;
                    Console.Beep();
                    model.score++;
                }
                else
                {
                    cki = default(ConsoleKeyInfo);
                    inputString = String.Empty;
                    Model.InputChars.Clear();
                }
            }

            Thread.Sleep(200);
        }
    }

    public void TimedEvent(Object source, ElapsedEventArgs e)
    {
        if (model.ActiveFish.Count < 7)
        {
            FishSpawner();
        }
    }

    public void FishSpawner()
    {
        lock (lockThis)
        {
            {
                var gameObject = new Model.GameObject
                {
                    Col = 6,
                    Row = RandomRow(),
                    ColSpeed = 1,
                    Text = model.Words[RandomWord()],
                    TextColor = ConsoleColor.Black,
                    BackColor = ConsoleColor.Gray,
                };
                {
                    model.ActiveFish.Add(gameObject);
                }
            }
        }
    }

        public void InputController()
        {
        }

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
                model.gameOver = true;
                gameObject.Col = Console.BufferWidth - 5;
                // gameObject.ColSpeed = -gameObject.ColSpeed;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(Console.BufferWidth / 2, Console.BufferHeight / 4);
                MyConsole.AskForText($"GAME OVER! Score: {model.score}");
            }
        }

        public static int RandomWord()
        {
            Model model = new Model();
            var max = model.Words.Length;
            Random random = new Random();
            int number = random.Next(0, max);
            return number;
        }

        public static int RandomRow()
        {
            var max = Console.BufferHeight;
            Random random = new Random();
            int number = random.Next(2, 40);
            return number;
        }
    }