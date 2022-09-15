
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