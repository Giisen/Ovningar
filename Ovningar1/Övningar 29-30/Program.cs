// 29.Skriv en klass som representerar en bil.
// Varje bil ska kunna ha en färg som representeras av en enum (det ska finnas minst 5 olika färger på bilar), samt en längd.
// När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
// Instansiera 1000 bilar och spara i en array. Skriv sedan ut den sammanlagda längden av alla gröna bilar.
/*
using Övningar_29_30;

Car[] cars=new Car[1000];

for (int i = 0; i <1000; i++)
{
    cars[i] = new Car();
    
}

int combinedLength = 0;
int getLength=0;
foreach (var item in cars)
{
    if (item.Color==Car.ColorEnum.GrassGreen)
    {
        getLength = (int)item.Length;
        //Console.WriteLine(item.Length);
        //Console.WriteLine((int)item.Length);
        combinedLength += getLength;
    }
}

Console.WriteLine($"Total längd på gröna bilar: {combinedLength}");
*/

//30 Gör en ny version av sten-sax-påse. Varje spelare ska representeras av ett “Player”-objekt.
//Man ska kunna anropa en metod på objekten som returnerar en enum med ett(random) av tre värden (sten, sax, påse).
//Objekten(klassen) ska ha en konstruktor som tar namn på spelaren, samt en x-, och y-koordinat som representerar
//ett ställe på skärmen där spelarens namn och poäng skrivs ut.
//Det ska finnas en property för poäng som automatisk uppdaterar spelarens poäng på den (x/y) positionen på skärmen varje gång man ändrar värdet på propertyn.
//Ex: På översta raden längst till vänster skrivs “Computer: 0”. Varje gång man uppdaterar poängen (t.ex computer.Score++;)
//så uppdateras poängen automatiskt på den positionen. Likadant för den andra spelaren.Dessutom ska det finnas en statisk metod på klassen
//som tar två enum (sten, sax, påse) och returnerar en ny enum (win, lose, draw) som säger om den första parametern man skickar in vinner över den andra (eller om det blir lika).
//Hint: Använd Console.CursorLeft och Console.CursorTop. Spara den tidigare positionen innan du ändrar; gör uppdateringen, och hoppa tillbaks.

using Övningar_29_30;
using static Övningar_29_30.Player;

Player player1 = new Player("Krister", 5, 5);
Player player2 = new Player("Noel", 25, 25);



Console.WriteLine(player1.Name);
Console.WriteLine(player1.Points);
Console.WriteLine(player1.X);
Console.WriteLine(player1.Y);
Console.WriteLine(player1.KastEnum());
RockPaperScissorsEnum kast1 = player1.KastEnum();

Console.WriteLine(player2.Name);
Console.WriteLine(player2.Points);
Console.WriteLine(player2.X);
Console.WriteLine(player2.Y);
Console.WriteLine(player2.KastEnum());
RockPaperScissorsEnum kast2 = player1.KastEnum();

if (player1.KastEnum() != player2.KastEnum())
{
    Console.WriteLine("Ej lika");
}
else
{
    Console.WriteLine("lika");
}


