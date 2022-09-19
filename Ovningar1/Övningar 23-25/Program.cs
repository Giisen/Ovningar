//23. Skapa en metod int[] IndexOfAll(string text, char c)
//som söker igenom strängen text och returnerar en int[] med index till alla förekomster av c i text.

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
            
            int result =i++;
            int[] index = new int[] { result };

            foreach (int x in index)
            {
                Console.Write(x);
            }

        }
       
    }

}



