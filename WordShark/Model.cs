using Christian;

public class Model
{
   public Model()
   {
   }

   public bool gameOver = false;
   public int score = 0;
   
   public string[] Words =
   [
      "Apple",
      "Orange",
      "Pear",
      "Pineapple",
      "Pine",
      "Boat",
      "House",
      "Hieroglyph",
      "Cat",
      "Samurai",
      "Baseball",
      "Mountain",
      "Turkey",
      "Quagmire",
      "Zephyr",
      "Xylophone",
      "Jubilee",
      "Cryptic",
      "Labyrinth",
      "Mnemonics",
      "Exquisite",
      "Fjord",
      "Gossamer",
      "Halcyon",
      "Incognito",
      "Juxtapose",
      "Kaleidoscope",
      "Luminescence",
      "Metamorphosis",
      "Nebula",
      "Obfuscate",
      "Paradox",
      "Quintessential",
      "Rhapsody",
      "Serendipity",
      "Tantalize",
      "Umbrella",
      "Vortex",
      "Wanderlust",
      "Xenophobia",
      "Yesteryear",
      "Zeppelin",
      "Aurora",
      "Bellwether",
      "Cacophony",
      "Dichotomy",
      "Ephemeral",
      "Felicity",
      "Gallivant",
      "Hapless",
      "Iridescent",
      "Jargon",
      "Kerfuffle",
      "Lethargy",
      "Melancholy",
      "Nefarious",
      "Oblivion",
      "Peregrine",
      "Quizzical",
      "Resonance",
      "Soliloquy",
      "Treacherous",
      "Ubiquitous",
      "Vicissitude",
      "Whimsical",
      "Xylograph",
      "Yonder",
      "Zealot",
   ];
   
   public List<GameObject> ActiveFish = new List<GameObject>();
   public static List<char> InputChars = new List<char>();
   
   
   public class GameObject
   {
      public int Col;
      public int Row;
      public int ColSpeed;
      public string Text;
      public ConsoleColor TextColor;
      public ConsoleColor BackColor;
      
   }
}