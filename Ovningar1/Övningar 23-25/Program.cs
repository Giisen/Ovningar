//23. Skapa en metod int[] IndexOfAll(string text, char c)
//som söker igenom strängen text och returnerar en int[] med index till alla förekomster av c i text.
/*
Console.WriteLine("Skriv in en text");
string text =Console.ReadLine();
char c = 'c';

IndexOfAll(text, c);

void IndexOfAll(string text, char c)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == c)
        {
           int[] index = new int[] {i};

            foreach (int x in index)
            {
                Console.Write(x+" ");
            }

        }
       
    }

}
*/

//24.Skriv ett program som skriver ut följande rektanglar på konsolen med hjälp av loopar:
/*
a.
#-------
-#------
--#-----
---#----


int h = 4;
int w = 8;
string hash = "#";
int hashindex = 0;
string dash = "-";

for (int j = 0; j < h; j++)
{
    for (int i = 0; i < w; i++)
    {
        if (i==hashindex)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
     }
    Console.WriteLine();
    hashindex++;    
}
*/

/*
b.
#---#---
-#---#--
--#---#-
---#---#


int h = 4;
int w = 8;
string hash = "#";
int hashindex = 0;
string dash = "-";

for (int j = 0; j < h; j++)
{
    for (int i = 0; i < w; i++)
    {
        if (i==hashindex || i==hashindex+4)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
     }
    Console.WriteLine();
    hashindex++;    
}

*/

/*
c.
##------
--##----
----##--
------##


int h = 4;
int w = 8;
string hash = "#";
int hashindex = 0;
string dash = "-";

for (int j = 0; j < h; j++)
{
    for (int i = 0; i < w; i++)
    {
        if (i==hashindex || i==hashindex+1)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
     }
    Console.WriteLine();
    hashindex=hashindex+2;    
}
*/

/*
d.
--#--#--
--#--#--
########
--#--#--


int h = 4;
int w = 8;
string hash = "#";
int hashindex = 2;
string dash = "-";

for (int j = 0; j < h; j++)
{
    
    for (int i = 0; i < w; i++)
    {
        if(j == 2)
        {
            Console.Write(hash);
        }
        else if (i == hashindex || i == hashindex + 3)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
    }
    Console.WriteLine();
    //hashindex = hashindex + 2;
}
*/



/*
e.
#---#---
-#-#----
--#-----
-#-#----


int h = 4;
int w = 8;
string hash = "#";
int hashindex = 0;
int hashindex2 = 4;
string dash = "-";

for (int j = 0; j < h; j++)
{

    for (int i = 0; i < w; i++)
    {
        if (i == hashindex || i==hashindex2)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
    }
    Console.WriteLine();
    hashindex++;
    hashindex2--;
}
*/


/*
f.
#-#-
-#-#
#-#-
-#-#



int h = 4;
int w = 4;
string hash = "#";
int hashindex = 0;

string dash = "-";

for (int j = 0; j < h; j++)
{
    if (j % 2 == 0)
    {

        for (int i = 0; i < w; i++)
        {
            if (i == hashindex || i == hashindex + 2)
            {
                Console.Write(hash);
            }
            else
            {
                Console.Write(dash);
            }
        }
    }
    else if (j % 2 == 1)

        for (int i = 0; i < w; i++)
        {
            if(i%2==1)
            {
                Console.Write(hash);
            }
            else
            {
                Console.Write(dash);
            }
        }
    Console.WriteLine();
 }
*/


/*
g.
###---
###---
###---
------


int h = 4;
int w = 6;
string hash = "#";
int hashindex = 0;

string dash = "-";

for (int j = 0; j < h; j++)
{
    for (int i = 0; i < w; i++)
    {
        if (j < 3 && i < 3)
        {
            Console.Write(hash);
        }
        else
        {
            Console.Write(dash);
        }
    }

    Console.WriteLine();
}

*/

/*
h.
--#--##
---#-##
----#--
-----#-


int h = 4;
int w = 7;
string hash = "#";
int hashindex = 2;
int hashindex2 = 5;

string dash = "-";

for (int j = 0; j < h; j++)
{
    if (j < 2)
    {

        for (int i = 0; i < w; i++)
        {
            if (i == hashindex || i == hashindex2 || i==hashindex2+1)
            {
                Console.Write(hash);
            }
            else
            {
                Console.Write(dash);
            }
        }
        
    }
    else if (j > 1)
    {

        for (int i = 0; i < w; i++)
        {
            if (i == hashindex)
            {
                Console.Write(hash);
            }
            else
            {
                Console.Write(dash);
            }

        }
    }
    hashindex++;
    Console.WriteLine();
}
*/

/*
i.
--#--
---- -
--#--
--#--

int h = 4;
int w = 5;
string hash = "#";
int hashindex = 2;
int hashindex2 = 5;

string dash = "-";

for (int j = 0; j < h; j++)
{
    if (j != 1)
    {

        for (int i = 0; i < w; i++)
        {
            if (i == w / 2)
            {
                Console.Write(hash);
            }
            else
            {
                Console.Write(dash);
            }
        }

    }
    else
    {
        for (int i = 0; i < w; i++)
        {
            Console.Write(dash);
        }

    }
    Console.WriteLine();
}
*/

/*
j.
#---#
-#-#-
--o--
-#-#-
#---#

int h = 5;
int w = 5;
string hash = "#";
int hashindex = 0;
int hashindex2 = w-1;

string dash = "-";

for (int j = 0; j < h; j++)
{
    if (j < 2)
    {

        for (int i = 0; i < w; i++)
        {
            if (i == hashindex || i==hashindex2)
            {
                Console.Write(hash);
                
            }
            else
            {
                Console.Write(dash);
            }
            
        }
        hashindex++;
        hashindex2--;

    }
    

    else if (j > 2)
    {
        hashindex--;
        hashindex2++;
        for (int i = 0; i < w; i++)
        {
            if (i == hashindex || i == hashindex2)
            {
                Console.Write(hash);
                
            }
            else
            {
                Console.Write(dash);
            }

        }
       
    }
    else
    {
        for (int i = 0; i < w; i++)
        {
            if (i == w / 2)
            {
                Console.Write("o");
            }
            else 
            { 
                Console.Write(dash); 
            }
        }
    }
    
    Console.WriteLine();
}
*/

/*-----------------------------------------------------------EJ KLAR!!!!--------------------------------------------   
k.                    
##--##--##--##--
##--##--##--##--
wwwwww~~~~~~~~~~
################


int h = 4;
int w = 16;
string hash = "#";
int hashindex = 0;
int hashindex2 = 1;
string www = "w";
string wave = "~";
string dash = "-";

for (int j = 0; j < h; j++)
{
    if (j < 2)
    {


        for (int i = 0; i < w; i++)
        {
            
            if (i == hashindex || i == hashindex + 1)
            {
                Console.Write(hash);

            }
            else
            {
                Console.Write(dash);
            }
            
        }


        //for (int i = 0; i < w; i++)
        //{
        //    if (i == hashindex)
        //    {
        //        Console.Write(hash);
        //        hashindex=hashindex+3;

        //    }
        //    else if(i==hashindex2)
        //    {
        //        Console.Write(hash);
        //        //hashindex2 = hashindex2 + 2;
        //    }
        //    else
        //    {
        //        Console.Write(dash);
        //    }
        //    //hashindex=hashindex+2;
        //    //hashindex2=hashindex2+2;
        //}
    }
    else if (j > 2)
    {
        for (int i = 0; i < w; i++)
        {
            
            {
                Console.Write(hash);
            }
        }

    }
    else
    {
        for (int i = 0; i < w; i++)
        {
            if (i <6)
            {
                Console.Write(www);
            }
            else
            {
                Console.Write(wave);
            }
        }
    }

    Console.WriteLine();
}
*/


//25.Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
//Skapa publika properties för att hämta eller ändra värdet på varje field.
//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen? Väljs beroende på hur många argument som anges
//Skriv en metod till bilklassen med namnet HalfPrice. När den anropas ska priset på bilen sänkas till hälften.

//public class Player
//{
//    private string _name;
//    public string Name
//    {

//        get { return _name; }
//        set { _name = value; }

//    }

//Player krister = new Player(); //instatierar en ny player Krister.
//krister.Alive = true;
//krister.Name = "Krister";
//krister.Level = 1;




Car polestar = new Car("polestar", 100, "white");

//polestar.Price = 100;

polestar.HalfPrice();
Console.WriteLine(polestar.Price);



public class Car
{
    private string _model;
    public string Model { get { return _model; } set { _model = value; } }

    private int _price;
    public int Price { get { return _price; } set { _price = value; } }

    private string _color;
    public string Color { get { return _color; } set { _color = value; } }

    public Car()
    {

    }

    public Car(string model, int price, string color) 
    {
    Model=model;
    Price=price;
    Color=color;
    }

    public int HalfPrice() //Ger ett nytt Price (hälften), denna ersätter tidigare _price.
    {
        Price = Price / 2;
        return Price;
    }

}



