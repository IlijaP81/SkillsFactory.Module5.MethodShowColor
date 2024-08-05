
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] userColors = new string[3];
        for (int i = 0; i < 3; i++)
        {
            userColors[i] = ShowColor(i);
            Console.WriteLine($"your color is {userColors[i]}"); 
        }
    }

    private static string ShowColor(int index)
    {
        Console.WriteLine($"Введите {index + 1}-й цвет по-английски с маленькой буквы:");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            default:
                color = "yellow";
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
        }
        return color;
    }
}