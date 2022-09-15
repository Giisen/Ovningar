
// 7.Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till månadens siffervärde.
// T.ex. ska januari bli 1 och december 12. Använd switch. Alternativ: Prova även att lösa uppgiften med array och/eller enum.


Console.WriteLine("skriv in en månad (ex: mars) och få ut numret för månaden.");
string manadinput = Console.ReadLine();
string manad = manadinput.ToLower();


switch (manad)
{
    case "januari":
        {
            Console.WriteLine("Månadens nummer är 1");
        }
        break;

    case "februari":
        {
            Console.WriteLine("Månadens nummer är 2");
        }
        break;

    case "mars":
        {
            Console.WriteLine("Månadens nummer är 3");
        }
        break;

    case "april":
        {
            Console.WriteLine("Månadens nummer är 4");
        }
        break;

    case "maj":
        {
            Console.WriteLine("Månadens nummer är 5");
        }
        break;

    case "juni":
        {
            Console.WriteLine("Månadens nummer är 6");
        }
        break;

    case "juli":
        {
            Console.WriteLine("Månadens nummer är 7");
        }
        break;

    case "augusti":
        {
            Console.WriteLine("Månadens nummer är 8");
        }
        break;

    case "september":
        {
            Console.WriteLine("Månadens nummer är 9");
        }
        break;

    case "oktober":
        {
            Console.WriteLine("Månadens nummer är 10");
        }
        break;

    case "november":
        {
            Console.WriteLine("Månadens nummer är 11");
        }
        break;

    case "december":
        {
            Console.WriteLine("Månadens nummer är 12");
        }
        break;

    default:
        {
            Console.WriteLine("Du skrev inte in en månad");
        }
        break;

}



//8.Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad).
//Fortsätt till du skrivit ut 16 rader.
/*

int n = 0;
for (int i=1; n<16;i*=2)
{
    Console.WriteLine(i);
    n++;
       
}

*/

//9. Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
//Programmet ska ha ett hemligt tal lagrat i en variabel.
//Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet.
//Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det.
//Exempel: programmet har det hemliga talet 27. Användaren gissar på 50.
//Programmet skriver ut att användaren gissade för högt. 
//Användaren gissar på 20. 
//Programmet skriver ut att det var för lågt. 
//Användaren gissar på 27. 
//Programmet skriver ut att det var rätt och avslutas.

/*
//int hemligtnummer = 67;
Random hemligtnummer = new Random();
int nummer = hemligtnummer.Next(1, 100);
//Console.WriteLine("Gissa ett tal mellan 1 och 100");
//string gissningtext = Console.ReadLine();
//int gissning = Int32.Parse(gissningtext);
int n = 0;
bool minBool = true;

while (minBool)
{
    
    Console.WriteLine("Gissa ett tal mellan 1 och 100");
    string gissningtext = Console.ReadLine();
    int gissning = Int32.Parse(gissningtext);
    n++;

    if (gissning < nummer)
    {
        Console.WriteLine("Det hemliga numret är högre");
        Console.WriteLine($"Du har gissat: {n} gånger\n");
    }
    else if (gissning > nummer)
    {
        Console.WriteLine("Det hemliga numret är lägre");
        Console.WriteLine($"Du har gissat: {n} gånger\n");
    }
    else
    {
        Console.WriteLine($"Du gissade rätt!!! på {n} gånger");
        
        minBool = false;
    }

    
}

*/