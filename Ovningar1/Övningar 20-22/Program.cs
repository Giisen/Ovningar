//20. Använd DrawBox-metoden i föregående uppgift för att rita en box.
//Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @.
//När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
//Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.

/*

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
*/


//21.Skriv om DrawBox så den istället returnerar en 2D-array av char
//med tecknen som den tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter
//för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.


Console.WriteLine("hur stor ska rutan vara? Börja med att ange bredden");
int inputwidth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange höjden");
int inputheight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange antalet slupade '#' inne i boxen");
int slumpHash = Convert.ToInt32(Console.ReadLine());

char[,] slumpHashArray = new char[inputheight, inputwidth]; //Denna ska sedan fyllas med #
char[,] xyArray = new char[inputheight, inputwidth];

int atX = inputwidth / 2; // Mitten av boxen
int atY = inputheight / 2; // Mitten av boxen
int[,] atArray = new int[atX, atY];

//int randomWidht = 0;
//int randomHeight = 0;
bool exitKey = false;

char at = '@';
char dash = '-';
char hash = '#';


DrawBox(inputheight, inputwidth); //DrawBox(height, width);
PrintBox();
void DrawBox(int height, int width) //void DrawBox(int height, int width)
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

    // Denna slumpar ut # inom boxen.....Här måste jag skap en ny array med dessa slumpade # för att sen jämföra om @ är samma som #
    for (int s = 0; s < slumpHash; s++)
    {
        Random rnd = new Random();
        int randomWidht = rnd.Next(1, width - 2);
        int randomHeight = rnd.Next(1, height - 2);
        xyArray[randomHeight, randomWidht] = hash;
    }

    Console.CursorVisible = false; //Gömmer Cursor

    Console.Clear();
}
void PrintBox()
{
    for (int h = 0; h < inputheight; h++)  //Skriver ut Arrayen, värdet på varje element i xyArray
    {
        for (int w = 0; w < inputwidth; w++)
        {
            Console.Write(xyArray[h, w]);
        }
        Console.WriteLine();
    }
}

// Skapar en ny array med bara "#"
for (int i = 0; i < xyArray.GetLength(0) - 1; i++) //Loopa genom rader
{
    for (int j = 0; j < xyArray.GetLength(1) - 1; j++) //loopa genom kolumner
    {
        if (xyArray[i,j]==at)
        {
            slumpHashArray[i,j] = at;
            
        }
        
    }
}




while (!exitKey)
{

    var inputKey = Console.ReadKey();

    for (int i = 0; i < slumpHashArray.GetLength(0) - 1; i++) //Loopa genom rader
    {
        for (int j = 0; j < slumpHashArray.GetLength(1) - 1; j++) //loopa genom kolumner
        {
            if (i == atX && j == atY)
            {
                Console.WriteLine("found match");
                exitKey = true;
            }
            else
            {
                break;
            }
        }
    }


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
                    //Console.SetCursorPosition(0, 0);
                    atX--;

                }
            }
            break;

        case ConsoleKey.RightArrow:

            {
                if (atX < inputwidth - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX + 1, atY);
                    Console.Write(at);
                    //Console.SetCursorPosition(0, 0);
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
                    //Console.SetCursorPosition(0, 0);
                    atY--;
                }
            }
            break;

        case ConsoleKey.DownArrow:

            {
                if (atY < inputheight - 2)
                {
                    Console.SetCursorPosition(atX, atY);
                    Console.Write(dash);
                    Console.SetCursorPosition(atX, atY + 1);
                    Console.Write(at);
                    //Console.SetCursorPosition(0, 0);
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


//22.Skriv en funktion som kan ta ett godtyckligt antal strängar som parametrar och som returnerar den längsta av dem.
/*
List<string> stringList = new List<string>();
//List<int> lenghtList = new List<int>();
bool strängar = true;

while (strängar)
{
    Console.WriteLine("Vill du skriva in en sträng, välj 1 om inte så välj 2");
    string val = Console.ReadLine();
    switch (val)
    {
        case "1":
            {
                Console.WriteLine("Skriv in din sträng");
                stringList.Add(Console.ReadLine());
                break;
            }
        default:
            {
                Console.WriteLine();
                Console.WriteLine("Den längsta strängen du skriv in är:");
                StringLenght();
                strängar = false;
                break;
            }
    }

}

void StringLenght()
{
    stringList = stringList.OrderByDescending(x => x.Length).ToList(); //Sorterar och skriver över listan
    //stringList.OrderByDescending(x => x.Length); // Sorterar men skriver inte över listan.
    Console.WriteLine(stringList[0]);
}
*/