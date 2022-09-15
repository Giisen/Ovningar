// 17. Gör ett program som ber användaren mata in en text.
// Be sedan användaren mata in en sträng som är en del av den första texten.
// Skriv ut hela texten med den del man angav markerad i en annan färg. Ex.
// Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”.
// Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz

/*
string inputFull = "abcdefghijklmnopqrstuvxyz";
string inputPart = "klmnopq";


int substringIndexStart = 0; //Index där första bokstaven som matchar (k) börjar

string ord0 = string.Empty;
string ord1 = string.Empty;
string ord2 = string.Empty;

//------------------------------------------Får ut vilket index delsträngen börjar på i fulla texten---------------
for (int j = 0; j < inputFull.Length; j++)
{
    for (int i = 0; i < 1; i++)
    {
        if (inputFull[j] == inputPart[i])
        {
            substringIndexStart = j;
        }
     }
}
//--------------------------------------------------------------------------------


int substringIndexInputPartLenght = inputPart.Length; // längden på inputen som ska jämföras, senare kallat ord1
int substringIndexInputFullLenght = inputFull.Length; // Totalt antal tecken i hela texten, behövs för att räkna ut ord2
int substringIndexStartOrd2 = substringIndexStart + substringIndexInputPartLenght; // räknar ut startposition för ord2
int substringIndexEnd = substringIndexInputFullLenght - substringIndexStartOrd2; // räknar ut hur många tecken som ord2 ska bestå av
ord0 = inputFull.Substring(0, substringIndexStart);
ord1 = inputFull.Substring(substringIndexStart, substringIndexInputPartLenght);
ord2 = inputFull.Substring(substringIndexStartOrd2, substringIndexEnd);

Console.Write(ord0);
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(ord1);
Console.ResetColor();
Console.Write(ord2);

*/


//18.Be användaren mata in en mening. Skriv ut det genomsnittliga antalet bokstäver i orden.

/*
Console.WriteLine("Vänligen skriv in en mening:");
string text = Console.ReadLine();
string textTrimmad = text.Trim();
string[] textArray = textTrimmad.Split(" ");


int numberofwords = 0;
for (int i = 0; i < textArray.Length; i++)
{
    numberofwords++;
}

int textLenght = textTrimmad.Length;
int antalmellanslag = numberofwords-1;
double textLenghtUtanMellanslag = textLenght - antalmellanslag;
double result = textLenghtUtanMellanslag/numberofwords;

Console.WriteLine($" Totalt antal tecken utan mellanslag: {textLenghtUtanMellanslag} antal ord: {numberofwords} medel: {result}");

*/



/*
//19.Skriv en metod DrawBox(int width, int height) När man anropar metoden ska den tömma konsolen
och skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’ Exempel:
DrawBox(7, 4);
#######
#-----#
#-----#
#######
*/

/*

DrawBox(10, 10); //Anropar metoden DrawBox och anger width och height

void DrawBox(int width, int height)
{

    Console.Clear();
    for (int x = 0; x < width - 1; x++)
    {
        Console.Write("#");
    }

    for (int y = 0; y < height - 2; y++)
    {
        Console.Write("#");
        Console.WriteLine();
        Console.Write("#");
        for (int z = 0; z < width - 2; z++)
        {
            Console.Write("-");
        }

    }
    Console.Write("#");
    Console.WriteLine();
    for (int q = 0; q < width; q++)
    {
        Console.Write("#");
    }
}
*/

/*
 *    void DrawBox(int w, int h)
    {
        Console.WriteLine(new string('#', w));
        Console.Write(string.Concat(Enumerable.Repeat($"#{new string(' ', w - 2)}#\n", h - 2))); 
        Console.WriteLine(new string('#', w));
    }
*/