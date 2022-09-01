// Från genomgången den 2022-09-01, Niklas visar på distans.

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
    Console.WriteLine($"Jag hittade ett {tecken} på plats {i}");
}