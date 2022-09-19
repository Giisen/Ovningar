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
*/

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

/*
c.
##------
--##----
----##--
------##
d.
--#--#--
--#--#--
########
--#--#--
e.
#---#---
-#-#----
--#-----
-#-#----
f.
#-#-
-#-#
#-#-
-#-#
g.
###---
###---
###---
------

h.
--#--##
-- -#-##
----#--
-----#-
i.
--#--
---- -
--#--
--#--
j.
#---#
-#-#-
--o--
-#-#-
#---#
k.
##--##--##--##--
##--##--##--##--
wwwwww~~~~~~~~~~
################

*/


