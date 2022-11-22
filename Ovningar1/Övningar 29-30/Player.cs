

using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Övningar_29_30;

public class Player
{
    private int _Points;

    public int Points
    {
        get { return _Points; }
        set { _Points = value; }
    }

    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    private int _X;

    public int X
    {
        get { return _X; }
        set { _X = value; }
    }

    private int _Y;

    public int Y
    {
        get { return _Y; }
        set { _Y = value; }
    }

 
    //Skapar en Enum för sten, sax och påse.
    public enum RockPaperScissorsEnum
    {
        Rock,
        Paper,
        Scissors,
    }

    //private RockPaperScissorsEnum var = new RockPaperScissorsEnum();

    // Skapar en random från RockPaperScissorsEnum
    public static Array values = Enum.GetValues(typeof(RockPaperScissorsEnum));
    public static Random random = new Random();
    public RockPaperScissorsEnum kast = (RockPaperScissorsEnum)values.GetValue(random.Next(values.Length));
    //Skapar en metod som skickar tillbaka (return) en randome sten, sax eller påse. Denna hämtar från random ovan

    
    public  RockPaperScissorsEnum KastEnum()
    {
    
        return kast;
    }


    // skapar en konstruktor som tvingar att man tar in namn och x,y, men som också lägger till en random sten sax påse från metoden ovan.
    public Player(string name, int x, int y) 
    {
        Name = name;
        X = x;
        Y = y;
        
        

    }


    public void Print(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine($"{Name} points {Points}\n\n");
    }


    //Skapar en Enum för win lose draw.
    public enum WinOrLoseEnum
    {
        win,
        lose,
        draw,
    }

    public static string result = string.Empty;

    public static string WinOrLoseResult(RockPaperScissorsEnum kastEnum1, RockPaperScissorsEnum kastEnum2)
    {
        
        if (kastEnum1 == RockPaperScissorsEnum.Rock && kastEnum2 == RockPaperScissorsEnum.Scissors
            || kastEnum1 == RockPaperScissorsEnum.Scissors && kastEnum2 == RockPaperScissorsEnum.Paper
            || kastEnum1 == RockPaperScissorsEnum.Paper && kastEnum2 == RockPaperScissorsEnum.Rock)
        {
            result = WinOrLoseEnum.win.ToString();
        }
        else if (kastEnum1 == RockPaperScissorsEnum.Rock && kastEnum2 == RockPaperScissorsEnum.Paper
                 || kastEnum1 == RockPaperScissorsEnum.Scissors && kastEnum2 == RockPaperScissorsEnum.Rock
                 || kastEnum1 == RockPaperScissorsEnum.Paper && kastEnum2 == RockPaperScissorsEnum.Scissors)
        {
            result = WinOrLoseEnum.lose.ToString();
        }

        else
        {
            result = WinOrLoseEnum.draw.ToString();
        }
  
        return result;
        
        
    }


}