
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

/*
// Rövarspråket

Console.WriteLine("Vänligen skriv in en text:");
string inputtext = Console.ReadLine();
//char[] inputChar = inputtext.ToCharArray();
char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
string[] vokstring = {"a","e","i","o","u","y","å","ä","ö"}; 
string output = string.Empty;
//string temp = string.Empty;


for (int i = 0; i < inputtext.Length; i++)
{
    output += inputtext[i];


    if (vokaler.Contains(inputtext[i]))
        {
            continue;
        }
    
        //output += inputtext[i];
        
    
    output += "o" + inputtext[i];
    //output += "o" + inputtext[i];
    //output += "o"+ inputtext[i];
    //temp += "o" + inputtext[i];
    //output += temp.ToLower();

}

Console.WriteLine(output);
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