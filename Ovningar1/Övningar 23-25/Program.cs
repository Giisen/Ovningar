//23. Skapa en metod int[] IndexOfAll(string text, char c)
//som söker igenom strängen text och returnerar en int[] med index till alla förekomster av c i text.

Console.WriteLine("Skriv in en text");
string text =Console.ReadLine();
char c = 'c';
//int index =;
int result =-1;
IndexOfAll(text, c);

//int[] ints = new int[text.Length] {IndexOfAll()};

void IndexOfAll(string text, char c)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == c)
        {
            
            result =i++;
            int[] index = new int[] {result};


            //string stringResult = result.ToString();
            //stringResult.ToArray();
            //int[] index=new int[i] {i};
            //return i;
            //Console.WriteLine(result); //Denna funkar
        }
        //Console.WriteLine(text[i]);
    }

    foreach(int i in index)
    {
        Console.WriteLine(i);
    }

}



