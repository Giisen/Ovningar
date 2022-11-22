// 29.Skriv en klass som representerar en bil.
// Varje bil ska kunna ha en färg som representeras av en enum (det ska finnas minst 5 olika färger på bilar), samt en längd.
// När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
// Instansiera 1000 bilar och spara i en array. Skriv sedan ut den sammanlagda längden av alla gröna bilar.

// 32.Lägg till en statisk metod på klassen i uppgift 29. Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.


using Övningar_29_30;
using static Övningar_29_30.Car;

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
        combinedLength += getLength;
    }
}


CarArray(new Car(),out Car silvercar);



//var bla = Car.CarArray(new Car());

//foreach (var i in bla)
//{
//    Console.WriteLine($"Min nya cararray {i.Color} {i.Length}");
//}
//Car.CarArray();



Console.WriteLine($"Total längd på gröna bilar: {combinedLength}");


//30 Gör en ny version av sten-sax-påse. Varje spelare ska representeras av ett “Player”-objekt.
//Man ska kunna anropa en metod på objekten som returnerar en enum med ett(random) av tre värden (sten, sax, påse).
//Objekten(klassen) ska ha en konstruktor som tar namn på spelaren, samt en x-, och y-koordinat som representerar
//ett ställe på skärmen där spelarens namn och poäng skrivs ut.
//Det ska finnas en property för poäng som automatisk uppdaterar spelarens poäng på den (x/y) positionen på skärmen varje gång man ändrar värdet på propertyn.
//Ex: På översta raden längst till vänster skrivs “Computer: 0”. Varje gång man uppdaterar poängen (t.ex computer.Score++;)
//så uppdateras poängen automatiskt på den positionen. Likadant för den andra spelaren.Dessutom ska det finnas en statisk metod på klassen
//som tar två enum (sten, sax, påse) och returnerar en ny enum (win, lose, draw) som säger om den första parametern man skickar in vinner över den andra (eller om det blir lika).
//Hint: Använd Console.CursorLeft och Console.CursorTop. Spara den tidigare positionen innan du ändrar; gör uppdateringen, och hoppa tillbaks.

/*
using Övningar_29_30;
using static Övningar_29_30.Player;

Player player1 = new Player("Krister", 0, 5);
Player computer = new Player("Computer", 25, 5);

player1.Points=0;
computer.Points=0;

bool playagain = true;

while (playagain)
{

    WinOrLoseResult(player1.KastEnum(), computer.KastEnum());
    //Console.Clear();
    Console.WriteLine($"You did: {player1.KastEnum()}");
    Console.WriteLine($"Computer did: {computer.KastEnum()}\n");
    
    
    Console.WriteLine($"You: {result}");
    if (result == "win")
    {
        player1.Points ++;
    }
    else if (result == "lose")
    {
        computer.Points++;
    }

    

    player1.Print(player1.X, player1.Y);
    computer.Print(computer.X, computer.Y);

    Console.WriteLine("Vill du spela igen? 'j' för ja 'n' för nej.");
    string input = Console.ReadLine().ToLower();
    if (input == "n")
    {
        playagain = false;
    }
}
*/