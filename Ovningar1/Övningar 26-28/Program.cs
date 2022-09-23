//26.Skapa en klass som kan användas som stegräknare. Den ska ha en property Steps som bara går att läsa;
//en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.
//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.
/*
StepCount mySteps = new StepCount();

for(int i=0; i<1000; i++)
{
    mySteps.Step();
}
Console.WriteLine(mySteps.Steps);




public class StepCount
{
    private int _Steps=0;
    public int Steps { get {  return _Steps; } set { _Steps=value; } }
 

public int Step()
    {
        return Steps++;
    }

    public int Reset()
    {
        Steps=0;
        return Steps++;
    }

}
*/

//27.Skapa en en klass som har en property “red” och en property “blue”. Båda ska vara en float och kunna ha ett värde mellan 0.0 och 100.0
//men de ska vara “sammankopplade” på så vis att värdena tillsammans alltid är 100.0
//d.v.s om man t.ex. sätter “blue” till 8.5 och sedan läser av “red” så ska den returnera 91.5
/*
Console.WriteLine("Välj 1 för att ange värde för Red, välj 2 för att ange värde för Blue:");
string val = Console.ReadLine();

float Blue = 0.0F;
float Red = 0.0F;

switch (val)
{
    case "1":
        {
            Console.WriteLine("Skriv in Red:");
            string redString = Console.ReadLine();
            Console.WriteLine();
            Red = float.Parse(redString);
            break;
        }

    case "2":
        {
            Console.WriteLine("Skriv in Blue:");
            string blueString = Console.ReadLine();
            Console.WriteLine();
            Blue = float.Parse(blueString);
            break;
        }
}


GetHundred test = new GetHundred();
test.Blue = Blue;
test.Red = Red;

test.ReturnHundred(Red,Blue);

public class GetHundred
{
    private float _red;
    private float _blue;

    public float Red { get { return _red; } set { _red = value; } }
    public float Blue { get { return _blue; } set { _blue = value; } }

    public void ReturnHundred(float Red, float Blue)
    {

        if (Red > 0)
        {
            Blue = 100.0F - Red;
            Console.WriteLine($"Blue är: {Blue}");
        }
        else
        {
            Red = 100.0F - Blue;
            Console.WriteLine($"Red är: {Red}");
        }

        
    }    
}
*/

//28.Skapa klassen “Person”, med properties “FirstName”,
//“LastName” och “Name”. Om man ändrar någon av dem, så ska man få ut rätt värden när man läser av de andra.
//Använd en konstruktor som tar parametrar “firstName” och “lastName” när man instansierar objekten.
//(I en första enklare version så kan Name vara read-only).
//Ex1. Person p = new Person(“Anna”, “Berg”); // => p.Name == “Anna Berg”
//Ex2. p.Name = “Per Lind”; // => p.FirstName == “Per”, p.LastName == “Lind”

using Övningar_26_28;

PersonClass testPerson1 = new PersonClass("Krister","Ekelund");


Console.WriteLine(testPerson1.Name);
Console.WriteLine(testPerson1.FirstName);
Console.WriteLine(testPerson1.LastName);

