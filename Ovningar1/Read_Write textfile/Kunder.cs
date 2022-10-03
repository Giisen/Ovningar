namespace Read_Write_textfile;

public class Kunder
{
    private string _namn;

    public string Namn
    {
        get { return _namn; }
        set { _namn = value; }
    }

    private string _losen;

    public string Lösen
    {
        get { return _losen; }
        set { _losen = value; }
    }

    public Kunder(string namn, string lösen)
    {
        _namn=namn;
        _losen = lösen;
    }
}