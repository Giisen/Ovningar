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
string[] minArray ={"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

Console.WriteLine("Vänligen skriv en siffra");
var input = int.TryParse(Console.ReadLine(), out int tal);

Console.WriteLine(minArray[tal]);
*/

// 11.B
/*
string[] minArray = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

Console.WriteLine("Vänligen skriv en siffra");
string input = Console.ReadLine();  
string output = string.Empty;

for(int i = 0; i < input.Length; i++)
{
    string teckenString = "" + input[i];
    int inputTal = int.Parse(teckenString);
    output += minArray[inputTal];
    if(i<input.Length-1)
    {
        output += "-";
    }
}

Console.WriteLine(output);
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

// Rövarspråket

Console.WriteLine("Vänligen skriv in en text:");
string inputtext = Console.ReadLine();
//char[] inputChar = inputtext.ToCharArray();
char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
string output = string.Empty;
//string temp = string.Empty;

for (int i = 0; i < inputtext.Length; i++)
{
    output += inputtext[i];
    if (vokaler.Contains(inputtext[i]))
    {
           continue;
    }
   
        output += "o" + inputtext[i];
    
    //output += "o" + inputtext[i];
    //output += "o"+ inputtext[i];
    //temp += "o" + inputtext[i];
    //output += temp.ToLower();

}

Console.WriteLine(output);
Console.ReadKey();






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

// övningar med Niklas

string text = "Hejsan svejsan";
//char[] textArray = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

string ord1 =string.Empty;
string ord2 =string.Empty;
bool hittadeord=false;


for (int i = 0; i < text.Length; i++)
{
    if (text[i]==' ')
    {
        hittadeord=true;
    }
    else if (hittadeord)
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


/*
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
        ord1 += text[i];
    }
    else
    {
        ord2 += text[i];
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




//Console.WriteLine(ord1);
//Console.WriteLine(ord2);

//Console.WriteLine(omvändord1);
//Console.WriteLine(omvändord2);
*/

// Lab1------------------------------------------------------------------------------------------
//Bryt om tecknet inte är en siffra!  ----Kanske köra en while skillt från 0-9??

/*
string input = "29535123p48723487597645723645";

string serie1 = string.Empty;
string serie2 = string.Empty;   
bool hittadeSerie1=false;




for (int i = 0; i <input.Length-1; i++)
{
    if (input[i] == input[i+1])
    {
        hittadeSerie1 = true;
    }
    else if (hittadeSerie1)
    {
        serie1 += input[i];
    }
    else
    {
        serie2 += input[i];
    }
}
Console.WriteLine(serie1);
Console.WriteLine(serie2);

*/



/*

//Skriv pseudokod för: "
//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j

//be om input från användaren, lagra input i en variabel
Console.WriteLine("Hej, skriv in en text");
string input = Console.ReadLine();


//För varje tecken i input
foreach (char i in input)
{
    //Skriv ut tecknet på en ny rad
    Console.WriteLine(i);
}

*/




//Metoder---------------------------------------------------Metoder-----------------------------------------

/*
int a = 1;
int b = 2;

PrintSum(a, b); //Detta anropar metoden!!!

 void PrintSum(int a, int b)// Namnen inom parantesen används bara där och inte någon annan stans, inom parantesen är våra parametrar
{
    Console.WriteLine(a+b);  //Returnerar summan
}
*/

//Metod som funkar för lab1

//void IsCharADigit()
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        if (char.IsDigit(text[i]))
//        {
//            Console.WriteLine($"Tecknet {text[i]} är ett tal");
//        }
//        else
//        {
//            Console.WriteLine($"Tecknet {text[i]} är inte ett tal");
//        }
//    }
//}






//Console.WriteLine("Srkiv in valfri text:");
//string text =Console.ReadLine();

//for(int i=0; i< text.Length; i++)
//{
//    if (char.IsDigit(text[i]))
//    {
//        Console.WriteLine($"Tecknet {text[i]} är ett tal");
//    }
//    else
//    {
//        Console.WriteLine($"Tecknet {text[i]} är inte ett tal");
//    }
//}


/*
string text = Console.ReadLine();
string abc = "abc";

if (text.Contains(abc))
{
    Console.WriteLine("Innehåller");
}
else
{
    Console.WriteLine("nope");
}



if (text.StartsWith(abc))
{
    Console.WriteLine("startar med");
}
else
{
    Console.WriteLine("startar med nope");
}


if (text.EndsWith(abc))
{
    Console.WriteLine("slutar med");
}
else
{
    Console.WriteLine("slutar med nope");
}


string substring = text.Substring(1,4);
Console.WriteLine(substring);

*/


//-----------------------------------------Random------------------------------------------
/*
Random rand=new Random();

for (int i = 0; i <5; i++)
{
    int tal = rand.Next(1,4);
    Console.WriteLine(tal);
}
*/
//-------------------------------------------------------------------------------------------


// ----------------------------------------------------Mer Metoder-------------------------------------------------------------


//void PrintSum(int a, int b) //-----detta kallas för signaturen
//{
//    Console.WriteLine(a+b);		// detta är signature body
//}




//int sum = Add(1, 2);
//Console.WriteLine(sum);

//int Add(int a, int b)
//{
//    return a + b;
//}

/*
Console.WriteLine("Skriv in tal 1");
string input;
input=Console.ReadLine();
//double input1=double.Parse(input);
double input1=double.Parse(Console.ReadLine());

Console.WriteLine("Skriv in operator");
input =Console.ReadLine();
char op = input[0];

Console.WriteLine("Skriv in tal 2");
input =Console.ReadLine();
double input2=double.Parse(input);

double result = Calculate(input1, input2, op);

Console.WriteLine($"Resultatet blir: {result}");


double Calculate(double a, double b, char op)
{
    switch(op)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            return a / b;
        default:
            return 0;
    }
}

*/


//En bubble sort

/*
int[] tal= new int[] {9,3,20,5,4,1};

for (int i = 0; i < tal.Length; i++)
{
    
    for (int j = 0; j < tal.Length; j++)
    {
        if (tal[i] < tal[j])
        {
            int temp = tal[i]; //temp första 9
            tal[i] = tal[j]; // tal[i] = 20
            tal[j] = temp; // tal[j] =9
        }

    }
    

}
foreach (int x in tal)
{
    Console.WriteLine(x);
}

*/


//-------------------------------------------------Array sort-------------------------------------------------

//Array.Sort väljer mellan olika typer av sort beroende på antalet element. Om det är 16 eller färre, då insertion sort.
// om det är väldigt många element så används heap sort. Annars quick sort.

/*

char[] bokstav = new char[] { 'a', 'å', 't','f', 'j', 'd' };

Array.Sort(bokstav);

foreach (char x in bokstav)
{
    Console.Write(x);
}

Console.WriteLine();


int[] tal = new int[] { 1, 7, 9, 54, 0, 3 };

Array.Sort(tal);

foreach (int y in tal)
{
    Console.Write(y);
}

Console.WriteLine();

string[] arr = new string[] {"Hund","hej","abc"};

Array.Sort(arr);

foreach (string z in arr)
{
    Console.Write(z+" ");
}

*/

//-----------------------------------------------------------------------







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


//20. Använd DrawBox-metoden i föregående uppgift för att rita en box.
//Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @.
//När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
//Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.

/*

Console.WriteLine("hur stor ska rutan vara? Börja med att ange bredden");
int bredd =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ange höjden");
int hojd = Convert.ToInt32(Console.ReadLine());


DrawBox(bredd, hojd); //Anropar metoden DrawBox och anger width och height


void DrawBox(int width, int height)
{
    int inneW=width-1;
    int inneH=height-1;
    Console.Clear();

    for (int h = 0; h < height; h++)
    {

        for (int w = 0; w < width; w++)
        {

            if (inneW<width)
            {
                Console.Write("I");
            }
            else
            {
                Console.Write("#");
            }
            //Console.Write("#");
        }
        Console.WriteLine();





        //Console.WriteLine();
        //for( h = 0; h < height - 1; h++)
        //{
        //    Console.Write("I");
        //}
        // Inne i denna loopen måste det vara som @ ska vara med.
        //for ( h = 0; h < height - 2; h++)
        //{
        //    Console.Write("#");
        //    Console.WriteLine();
        //    Console.Write("#");
        //    int mittenH =height/2;
        //    int mittenW =width/2;
        //    int wInne = w - 2;
        //    var hInne = h - 2;


        //    for (z=0; wInne; z++)
        //    {
        //        Console.WriteLine("-");
        //    }


        //for (int z = 0; z < width - 2; z++)
        //{
        //    Console.Write("-");
        //}

        //if (atY == mittenH)
        //{
        //    Console.Write("@");
        //}



        //Console.Write("#");
        //Console.WriteLine();
        //for (int q = 0; q < width; q++)
        //{
        //    Console.Write("#");
        //}

    }
}

*/