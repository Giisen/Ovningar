//26.Skapa en klass som kan användas som stegräknare. Den ska ha en property Steps som bara går att läsa;
//en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.
//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.

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
 //public string Model { get { return _model; } set { _model = value; } }

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
