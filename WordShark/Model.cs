using Christian;

public class Model
{
   public Model()
   {
   }


   public string[] Words =
   [
      "Apple",
      "Orange",
      "Pear",
      "Pineapple",
      "Pine",
      "Boat",
      "House",
   ];
   
   public List<GameObject> ActiveFish = new List<GameObject>();

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