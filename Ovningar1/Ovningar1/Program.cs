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

/*
bool minbool =true;
int n = 0;
int summa = 0;
while (minbool)
{
    Console.WriteLine("Skriv ett tal:");
    int tal;
    var input = int.TryParse(Console.ReadLine(), out tal); //TryParse spara även värde som true eller false, därför kan vi använda det i vår if-sats, input är true om det är en int annars false
    
    
    summa += tal;

    if (input)
    {
        Console.WriteLine($"Summan av talen är: {summa}");
        n++;
        Console.WriteLine($"Antal gånger {n}");
    }
    else
    {
        
        Console.WriteLine("Du skrev inte in ett nummer");
        Console.WriteLine($"Summan av talen är: {summa}");
        Console.WriteLine($"Antal gånger {n}");
        Console.WriteLine($"Medel är: " +  (summa/n));
        minbool=false;
    }
}
*/



// 6.Skriv ett program som först frågar efter ett tal,
// sedan frågar efter ett av följande tecken: +, -, *eller /.
// Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare.
// Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.

/*
Console.WriteLine("skriv in ett tal");
//int tal1;
var input1 = int.TryParse(Console.ReadLine(), out int tal1);
Console.WriteLine("Vad vill du göra med tal 1? (+ - / eller *?");
string tecken = Console.ReadLine();
Console.WriteLine("skriv in ytterligare ett tal");
//int tal2;
var input2 = int.TryParse(Console.ReadLine(), out int tal2);
//int summa = (tal1 + tal2);

switch (tecken)
{
    case "+":
        {
            Console.WriteLine("Summan är: " + tal1 + tal2);
        }
        break;

    case "-":
        {
            Console.WriteLine("Summan är: " + (tal1 - tal2));
        }
        break;

    case "/":
        {
            Console.WriteLine("Summan är: " + (tal1 / tal2));
        }
        break;

    default:
        {
            Console.WriteLine("Summan är: " + (tal1 * tal2));
        }
        break;

}

*/

// 7.Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till månadens siffervärde.
// T.ex. ska januari bli 1 och december 12. Använd switch. Alternativ: Prova även att lösa uppgiften med array och/eller enum.

/*
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

*/

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

// 10.Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j

/*
Console.WriteLine("Skriv in en sträng ex hej");
string text = Console.ReadLine();

for(int i=0;i<text.Length;i++)
{
    Console.Write(text[i]+" ");
}
*/


// 11. Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
// Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.
/*
string[] minArray = new string[10] {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

Console.WriteLine("Vänligen skriv en siffra");
var input = int.TryParse(Console.ReadLine(), out int tal);

Console.WriteLine(minArray[tal]);
*/


// 12.Fråga användaren hur många tal den vill mata in.
// Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
// När alla tal är inmatade skriv ut dem i omvänd ordning.

/*
Console.WriteLine("Hur många tal vill du skriva in?");
var input = int.TryParse(Console.ReadLine(), out int tal);
int[] minArray =new int[tal];

for(int i = 0; i < tal; i++)
{
    Console.WriteLine($"Ange tal {i}: ");
    var input2 = int.TryParse(Console.ReadLine(), out int tal2);
    minArray[i] =tal2;
}
for(int i = minArray.Length-1; i>=0 ; i--)
{
    Console.Write(minArray[i] + " ");
}


*/

// 13.Be användaren mata in en text. Skriv sedan ut texten baklänges.

/*

Console.WriteLine("Vänligen skriv in en text:\n");
string inputtext = Console.ReadLine();
char[] charArray = inputtext.ToCharArray();
Array.Reverse(charArray);

foreach (char c in charArray)
{
    Console.Write(c);
}


*/

// 14.Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *
/*
Console.WriteLine("Vänligen skriv in en text:\n");
string inputtext = Console.ReadLine();
//var[] vokaler = new var[9] { "a", "e", "i", "o", "u", "y","å", "ä", "ö" };
string outputtext = inputtext.Replace("a", "*").Replace("e", "*").Replace("i", "*").Replace("o", "*").Replace("u", "*").Replace("y", "*").
    Replace("å", "*").Replace("ä", "*").Replace("ä", "*");

Console.WriteLine(outputtext);

Console.ReadKey();
*/


//15. Ett palindrom är ett ord som blir samma framlänges som baklänges.
//Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

/*
Console.WriteLine("Vänligen skriv in ett ord:");
string ord = Console.ReadLine();

char[] ordArray = ord.ToCharArray(); // Gör om strängen 'ord' till en array för att kunna vända på bokstäverna i ordet.

Array.Reverse(ordArray); //vänder ordning på arrayen

string ordreverseString = string.Concat(ordArray); // skapar en string av arrayen

//Console.WriteLine(ordreverseString);

if(ord==ordreverseString)
{
    Console.WriteLine("Ordet är ett palindrom!");
}
else
{
    Console.WriteLine("Ordet är inte ett palindrom!");
}

*/

// 16. Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra talet).
// Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.

/*
Console.WriteLine("skriv in en uppgift du vill ha uträknad (ex 4*3 eller 32+98)");
string input = Console.ReadLine();
string outputtext = input.Replace(" ", ""); //Tar bort alla mellanslag (white space)



char[] teckenArray = new char[] { '+', '-', '*', '/' };

string[] tal1string = outputtext.Split(teckenArray); //Splittar outputtext när det förekommer + eller - eller * eller /, till en ny array med två index.

//int tal1 = int.Parse(tal1string[0]); //Gör om index 0 från string till int
//int tal2 = int.Parse(tal1string[1]); //Gör om index 2 från string till int

double tal1 = double.Parse(tal1string[0]); // Gör om index 0 från string till en double
double tal2 = double.Parse(tal1string[1]); // Gör om index 1 från string till en double

if (outputtext.Contains('+'))
{
  Console.WriteLine($"Summan är:  {(tal1 + tal2)}");
}

else if (outputtext.Contains('-'))
{
  Console.WriteLine($"Summan är:  {(tal1 - tal2)}");
}

else if(outputtext.Contains('*'))
{
  Console.WriteLine($"Summan är: {(tal1 * tal2)}");
}
else if(outputtext.Contains('/'))
{
  Console.WriteLine($"Summan är:  {(tal1 / tal2)}");
}

*/



// övningar med Niklas
/*
string text = "Hejsan svejsan";
char[] textArray = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

string ord1 =string.Empty;
string ord2 =string.Empty;
bool hittadeord1=false;


for (int i = 0; i < text.Length; i++)
{
    if (text[i]==' ')
    {
        hittadeord1=true;
    }
    else if (hittadeord1)
    {
        ord2 += text[i];
    }
    else
    {
        ord1+=text[i];
    }
}

Console.WriteLine(ord1);
Console.WriteLine(ord2);

*/
/*
// Använder CharArray ist för string.
string text = "Hejsan svejsan";
char[] textArray = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

string ord1 = string.Empty;
string ord2 = string.Empty;
bool hittadeord1 = false;


for (int i = 0; i < textArray.Length; i++)
{
    if (text[i] == ' ')
    {
        hittadeord1 = true;
    }
    else if (hittadeord1)
    {
        ord2 += text[i];
    }
    else
    {
        ord1 += text[i];
    }
}

Console.WriteLine(ord1);
Console.WriteLine(ord2);
*/

/*
// Kör omvänd ordning för arrayen och orden.
string text = "Hejsan svejsan";
char[] textArray = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

string ord1 = string.Empty;
string ord2 = string.Empty;
bool hittadeord1 = false;


for (int i = textArray.Length-1; i >=0; i--)
{
    if (text[i] == ' ')
    {
        hittadeord1 = true;
    }
    else if (hittadeord1)
    {
        ord2 += text[i];
    }
    else
    {
        ord1 += text[i];
    }
}

Console.WriteLine(ord1);
Console.WriteLine(ord2);

*/

string text = "Hejsan svejsan";
char[] textArray = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

string ord1 = string.Empty;
string ord2 = string.Empty;
bool hittadeord1 = false;


for (int i = textArray.Length - 1; i >= 0; i--)
{
    if (text[i] == ' ')
    {
        hittadeord1 = true;
    }
    else if (hittadeord1)
    {
        ord2 += text[i];
    }
    else
    {
        ord1 += text[i];
    }
}

string omvändord1=string.Empty;
string omvändord2 = string.Empty;

for (int i = ord1.Length - 1; i >= 0; i--)
{
    omvändord1+=ord1[i]; // ord1 +text[i]   plussar sig själv med något annat.
}

for (int i = ord2.Length - 1; i >= 0; i--)
{
    omvändord2 += ord2[i];
}



Console.WriteLine(ord1);
Console.WriteLine(ord2);

Console.WriteLine(omvändord1);
Console.WriteLine(omvändord2);

