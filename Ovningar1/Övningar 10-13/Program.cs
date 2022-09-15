// 10.Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j


Console.WriteLine("Skriv in en sträng ex hej");
string text = Console.ReadLine();

for(int i=0;i<text.Length;i++)
{
    Console.Write(text[i]+" ");
}



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