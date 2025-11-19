namespace ConsoleApp;
    
public class DrawUI
{
    public static string DrawHeader()
    {
        AsciiArt art = new AsciiArt();
        string header = $"{art.borders[2]} {Model.users[0].name} {art.borders[2]}";
        return header;
    }    
}