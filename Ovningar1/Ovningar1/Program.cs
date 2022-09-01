// Från genomgången den 2022-09-01, Niklas visar på distans.

/*
int heltal = 0; //Variabeln är deklarerad (int) och initierad (0)
char tecken = 't'; // endast ett tecken
double decimaltal = 0.5; //Viktigt att det är en punkt mellan
string text = "min text";

if (heltal >0)
{
    Console.WriteLine("heltal är stäörre än 0");
}
else if (decimaltal >1.0)
{
    Console.WriteLine("Decimaltal är större än 1.0");
}
else
{
    Console.WriteLine("Inget av ovan gick igenom");
}

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == tecken)
    Console.WriteLine($"Jag hittade ett '{tecken}', på plats {i}");
}

foreach (char ch in text)
{
    Console.WriteLine(ch);
}

*/

//-------------------------------------------------------------------------------------------Övningar----------------------------------------------------------------

// 1. Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
// Om namnet är "David" ska det skriva ut "Hej David!"

/*
Console.WriteLine("Vad heter du?");
string namn=Console.ReadLine();
Console.WriteLine("Skriv ett tal");
int antal = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < antal; i++)
{
    Console.WriteLine($"Hej {namn}!");
}

*/

/*
// 2.Skriv ett program som frågar användaren efter ett lösenord. 
//Hitta på ett hemligt lösenord och spara det i en variabel. 
//När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet
//och skriva ut om det var rätt eller inte. Använd en if-sats.

Console.WriteLine("Ange ett lösenord:");
string losenord = "Password";
string losenordinput = Console.ReadLine();


if (losenord != losenordinput)
{
    Console.WriteLine("Det är fel lösenord");
}

else
{
    Console.WriteLine("Välkommen in");
}
*/

// 3.Skriv ett program som frågar användaren efter ett tal.
// Det ska skriva ut om talet är mindre än 100, lika med 100 eller större

/*
Console.WriteLine("Ange ett tal mellan 0 och 100");
int tal = Convert.ToInt16(Console.ReadLine());

if (tal == 100)
{
    Console.WriteLine("Ditt tal är lika med 100");
}
else if (tal>100)
{
    Console.WriteLine("Ditt tal är mer än 100");
}

else if(tal<100)  //Eftersom det är tal så behöver jag inte else if.... skulle kunna göra bara else.
{
    Console.WriteLine("Ditt tal är mindre än 100");
}

Console.ReadKey(); 
*/

// 4.Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal.
// Skriv hälsningen så många gånger som användaren anger.

// Se övning 1

//5.Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter).
//Efter varje inmatning ska summan av alla tal som matats in skrivas ut,
//innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.
//Hint: TryParse()

bool minbool =true;
int n = 0;
int summa = 0;
while (minbool)
{
    Console.WriteLine("Skriv ett tal:");
    int tal;
    var input = int.TryParse(Console.ReadLine(), out tal); //TryParse spara även värde som true eller false, därför kan vi använda det i vår if-sats, input är true om det är en int annars false
    n++;
    
    summa+= tal;

    if (input)
    {
        Console.WriteLine($"Summan av talen är: {summa}");
        Console.WriteLine($"Antal gånger {n}");
    }
    else
    {
        Console.WriteLine("Du skrev inte in ett nummer");
        Console.WriteLine($"Medel är: " +  summa/n);
        break;
    }
}
