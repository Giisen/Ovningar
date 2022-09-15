
//20. Använd DrawBox-metoden i föregående uppgift för att rita en box.
//Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @.
//När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
//Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.



Console.WriteLine("hur stor ska rutan vara? Börja med att ange bredden");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange höjden");
int height = Convert.ToInt32(Console.ReadLine());

int widhtMitt = width / 2;
int heightMitt = height / 2;
int atX = widhtMitt;
int atY = heightMitt;
bool exitKey = false;
string at = "@";
string dash = "-";
string hash = "#";

DrawBox(width, height);

void DrawBox(int width, int height)
{

    Console.Clear();
    for (int h = 0; h < height; h++)
    {

        for (int w = 0; w < width; w++)
        {

            if (h == 0 || h == height - 1 || w == 0 || w == width - 1)
            {
                Console.Write(hash);
            }
            else if (w == atX && h == atY)
            {
                Console.Write(at);
            }
            else
            {
                Console.Write(dash);
            }

        }
        Console.WriteLine();
    }
}

Console.CursorVisible = false; //Gömmer Cursor


while (!exitKey)
{
    var inputKey = Console.ReadKey();

    switch (inputKey.Key)
    {

        case ConsoleKey.LeftArrow:

            {
                if (atX > 1)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX - 1, atY);
                    Console.Write(at);
                    Console.SetCursorPosition(0,0);
                    atX--;
                    
                }
            }
            break;

        case ConsoleKey.RightArrow:

            {
                if (atX < width - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX + 1, atY);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atX++;
                    
                }
            }
            break;

        case ConsoleKey.UpArrow:

            {
                if (atY > 1)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX, atY-1);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atY--;
                }
            }
            break;

        case ConsoleKey.DownArrow:

            {
                if (atY < height - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX, atY + 1);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atY++;
                }
            }
            break;

        default:
            {
                exitKey = true;
            }
            break;
    }
}

/*

//21.Skriv om DrawBox så den istället returnerar en 2D-array av char
//med tecknen som den tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter
//för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.

Console.WriteLine("hur stor ska rutan vara? Börja med att ange bredden");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange höjden");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange antalet slupade '#' inne i boxen");
int slumpHash = Convert.ToInt32(Console.ReadLine());

string[,] xyArray = new string[height, width];

int atX = width / 2; // Mitten av boxen
int atY = height / 2; // Mitten av boxen
bool exitKey = false;
string at = "@";
string dash = "-";
string hash = "#";


DrawBox(height, width);

void DrawBox(int height, int width)
{

    for (int h = 0; h < height; h++)
    {

        for (int w = 0; w < width; w++)
        {

            if (h == 0 || h == height - 1 || w == 0 || w == width - 1) //Skriv ut # i kanterna
            {
                xyArray[h, w] = hash;
            }

            else if (w == atX && h == atY) // Om mitten, skriv ut@
            {
                xyArray[h, w] = at;
            }
            else
            {
                xyArray[h, w] = dash;
            }

        }

        Console.WriteLine();

    }

    // Denna slupmar ut # inom boxen
    for (int s = 0; s < slumpHash; s++)
    {
        Random rnd = new Random();
        int randomWidht = rnd.Next(1, width - 2);
        int randomHeight = rnd.Next(1, height - 2);
        xyArray[randomHeight, randomWidht] = hash;
    }

    Console.CursorVisible = false; //Gömmer Cursor

    Console.Clear();

    for (int h = 0; h < height; h++)  //Skriver ut Arrayen
    {
        for (int w = 0; w < width; w++)
        {
            Console.Write(xyArray[h, w]);
        }
        Console.WriteLine();
    }

    foreach (int w in width) // Loopa genom arrayen för att kolla #?
        if (xyArray[height - 2, width - 2] == "#") // Hitta # i arrayen och jämför med positionen för atX och atY
        {
            Console.WriteLine(xyArray[height, width]);
            //exitKey = true;
            //break;
        }
        else
        {
            Console.WriteLine("No match");
        }
}

/*

while (!exitKey)
{

    var inputKey = Console.ReadKey();

    switch (inputKey.Key)
    {

        case ConsoleKey.LeftArrow:

            {
                if (atX > 1)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX - 1, atY);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atX--;

                }
            }
            break;

        case ConsoleKey.RightArrow:

            {
                if (atX < width - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX + 1, atY);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atX++;

                }
            }
            break;

        case ConsoleKey.UpArrow:

            {
                if (atY > 1)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX, atY - 1);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atY--;
                }
            }
            break;

        case ConsoleKey.DownArrow:

            {
                if (atY < height - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX, atY + 1);
                    Console.Write(at);
                    Console.SetCursorPosition(0, 0);
                    atY++;
                }
            }
            break;

        default:
            {
                exitKey = true;
            }
            break;
    }

}
}
*/