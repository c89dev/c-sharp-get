namespace BarrenEscapades;
    
internal class DrawUI
{
    public static string DrawHeader()
    {
        AsciiArt art = new AsciiArt();
        string header = $"{art.borders[0]} {Model.users[0].name} {art.borders[1]}";
        return header;
    }    
}