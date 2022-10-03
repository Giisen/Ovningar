

using System;
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

    //private string _kast;

    //public string Kast
    //{
    //    get { return _kast; }
    //    set { _kast = value; }
    //}

    private RockPaperScissorsEnum _RndKast;

    public RockPaperScissorsEnum RndKast
    {
        get { return _RndKast; }
        set { _RndKast = RPSRand; }
    }

  
    //Skapar en Enum för sten, sax och påse.
    public enum RockPaperScissorsEnum
    {
        Rock,
        Paper,
        Scissors,
    }

    private RockPaperScissorsEnum var = new RockPaperScissorsEnum();

    // Skapar en random från RockPaperScissorsEnum
    static Array values2 = Enum.GetValues(typeof(RockPaperScissorsEnum));
    static Random random2 = new Random();
    public RockPaperScissorsEnum RPSRand = (RockPaperScissorsEnum)values2.GetValue(random2.Next(values2.Length));

    //Skapar en metod som skickar tillbaka (return) en randome sten, sax eller påse. Denna hämtar från random ovan
    public RockPaperScissorsEnum KastEnum()
    {
        return RPSRand;
    }


    // skapar en konstruktor som tvingar att man tar in namn och x,y, men som också lägger till en random sten sax påse från metoden ovan.
    public Player(string name, int x, int y) //, RockPaperScissorsEnum kast)
    {
        Name = name;
        X = x;
        Y = y;
        
    }

    public enum ResulatEnum
    {
        Win,
        Draw,
        Loose,
    }

   



    public void  Resultat()
    {
        
        if (RockPaperScissorsEnum.Rock && RockPaperScissorsEnum.Scissors)
        {
            //return ResulatEnum.Win;
            return "Player 1 Wins!";
        }
        else if (Kast1 == RockPaperScissorsEnum.Scissors && Kast2 == RockPaperScissorsEnum.Paper)

        {
            return ResulatEnum.Win;
            //return "Player 1 wins!";
        }

        else if (Kast1 == RockPaperScissorsEnum.Paper && Kast2 == RockPaperScissorsEnum.Rock)
        {
            return ResulatEnum.Win;
            //return "Player 1 wins!";
        }

        else if (Kast1 == Kast2)
        {
            return ResulatEnum.Draw;
            //return "It´s a Draw";
        }

        else
        {
            return ResulatEnum.Loose;
            //return "Player 2 wins!";
        }

    }

}