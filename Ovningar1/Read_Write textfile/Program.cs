using Read_Write_textfile;
using System.IO;
using System.Reflection.Metadata;

var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
var file = Path.Combine(desktop, "Users.txt");

List<Kunder> KundLista = new List<Kunder>();
KundLista.Add(new Kunder("k","123"));
KundLista.Add(new Kunder("L", "123456789"));
KundLista.Add(new Kunder("Noel","hej"));
KundLista.Add(new Kunder("Lisa","321"));
KundLista.Add(new Kunder("Emil","ipad"));



using (StreamWriter sw = new StreamWriter(file,true))
{
    foreach (var kund in KundLista)
    {
        sw.Write($"{kund.Namn} ");
        sw.WriteLine(kund.Lösen);
    }
}





// Hänvisning till min textfil där användare och password är sparat
using (StreamReader sr = new StreamReader(file))//new StreamReader("C:\\Users\\krist\\Documents\\GitHub\\Lab2\\Users.txt")) 
{
    // Läser första raden
    string line = sr.ReadLine();
    

    while (line != null)
    {
        Console.WriteLine($"Skriver ut alla {line}");
        // Läs nästa rad
        line = sr.ReadLine();
    }


    // Får inte fler whileloopar att funka
    //Console.WriteLine("Första While");
    ////sr.DiscardBufferedData();
    ////string line2 = sr.ReadLine();
    //// Läs varje rad tills raden är null
    ////line = sr.ReadLine();
    //while (line != null)
    //{
    //    if(line.Contains("Lisa"))
    //    // Skriv ut raden i filen
    //    Console.WriteLine($"Hittar {line}");
    //    // Läs nästa rad
    //    line = sr.ReadLine();
    //}

}
//Stänger filen
//sr.Close();


Console.ReadKey();

// Bra klasser att ha koll på.
//File 
//Environment
//Path
