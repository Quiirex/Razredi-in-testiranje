// Razredi (Classes): 
// Razredi so temeljna enota OOP in predstavljajo modele objektov.

public class Oseba
{
    public string Ime;
    public int Starost;
}

//////////////////////////////////////////////////////////////////////////////////////
// Lastnosti (Properties):
// Lastnosti so podatki, ki jih ima objekt.

public class Oseba
{
    public string Ime; // Ime je lastnost
    public int Starost; // Starost je lastnost
}

//////////////////////////////////////////////////////////////////////////////////////
// Fieldi (Fields):
// Fieldi so (skoraj vedno) zasebni za razred in 
// dostopni preko rezerviranih besed (get in set).
// Lastnosti zagotavljajo raven abstrakcije, 
// ki omogoča spreminjanje fieldov, 
// ne da bi vplivale na zunanji način, kako do njih dostopajo stvari, 
// ki uporabljajo vaš razred.

public class Razred
{
    // to je field.  Je zaseben za razred in hrani dejanske podatke. 
    private string _mojField;

    // to je lastnost. Ko do nje dostopate, uporablja osnovni field,
    // vendar izpostavi samo "pogodbo", na katero osnovni field ne bo vplival.
    public string MojaLastnost
    {
        get
        {
            return _mojField;
        }
        set
        {
            _mojField = value;
        }
    }

    // zgornje je isto kot:
    public string MojaLastnost { get; set; }
}

//////////////////////////////////////////////////////////////////////////////////////
// Objekti (Objects): 
// Objekti so primerki razredov, ki dejansko obstajajo v programu. 
// Lahko ustvarimo več objektov istega razreda.

// Najprej potrebujemo razred:
public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

// Nato ustvarimo objekt:

Oseba oseba1 = new Oseba();
oseba1.Ime = "Janez";
oseba1.Starost = 20;

// Nato uporabimo objekt:
public static void Main()
{
    Oseba oseba1 = new Oseba();
    oseba1.Ime = "Janez";
    oseba1.Starost = 20;
    Console.WriteLine(oseba1.Ime + " je star " + oseba1.Starost + " let.");
}

//////////////////////////////////////////////////////////////////////////////////////
// Konstruktorji (Constructors): 
// Konstruktorji so posebne metode razreda, 
// ki se kličejo ob ustvarjanju objekta 
// in omogočajo inicializacijo objekta.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public Oseba(string ime, int starost)
    {
        this.Ime = ime;
        this.Starost = starost;
    }
}

// 'This' rezervirana beseda se uporablja za sklicevanje na trenutni objekt.

//////////////////////////////////////////////////////////////////////////////////////
// Encapsulacija (Encapsulation): 
// Encapsulacija pomeni skrivanje podatkov razreda 
// pred neposrednim dostopom 
// ter zagotavljanje dostopa prek javnih vmesnikov (getters in setters).

public class Oseba
{
    private string ime;
    private int starost;

    public string Ime
    {
        get { return ime; }
        set { ime = value; }
    }

    public int Starost
    {
        get { return starost; }
        set { starost = value; }
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Dedovanje (Inheritance): 
// Dedovanje omogoča ustvarjanje novih razredov (podrazredov), 
// ki podedujejo lastnosti in metode obstoječega razreda (nadrazreda).
// Podrazredi lahko nadgradijo ali spremenijo obstoječe lastnosti in metode.
// V C# lahko razred deduje od večih razredov.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

public class Student : Oseba
{
    public int Letnik { get; set; }
}

// Primer uporabe:
Student student1 = new Student();
student1.Ime = "Janez";
student1.Starost = 20;
student1.Letnik = 2;

// Večkratno dedovanje (Multiple Inheritance):

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
}

public class Student : Oseba
{
    public int Letnik { get; set; }
}

public class Zaposlen : Oseba
{
    public int Placa { get; set; }
}

public class StudentZaposlen : Student, Zaposlen
{
    public int Placa { get; set; }
}

// Primer uporabe:
StudentZaposlen studentZaposlen1 = new StudentZaposlen();
studentZaposlen1.Ime = "Janez";
studentZaposlen1.Starost = 20;
studentZaposlen1.Letnik = 2;
studentZaposlen1.Placa = 1000;

//////////////////////////////////////////////////////////////////////////////////////
// Polimorfizem (Polymorphism): 
// Polimorfizem omogoča, da različni objekti istega nadrazreda 
// uporabljajo enake metode na svoj način. 
// To omogoča prilagajanje vedenja razredov.

public class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public virtual void Pozdravi()
    {
        Console.WriteLine("Pozdravljen, " + Ime + "!");
    }
}

public class Student : Oseba
{
    public int Letnik { get; set; }

    public override void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Abstraktni razredi in metode (Abstract Classes and Methods): 
// Abstraktne razrede in metode uporabljamo za definiranje skupnih lastnosti, 
// vendar njihove dejanske implementacije odložimo na podrazrede.

public abstract class Oseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }

    public abstract void Pozdravi();
}

public class Student : Oseba
{
    public int Letnik { get; set; }

    public override void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

// Še en primer:
abstract class Zival
{
    // Abstraktna metoda (nima telesa)
    public abstract void zvokZivali();
    // Navadna metoda
    public void spi()
    {
        Console.WriteLine("Zzz");
    }
}

// Izpeljani razred (podeduje od Zival)
class Prasic : Zival
{
    public override void zvokZivali()
    {
        // Telo metode zvokZivali() je podano tukaj
        Console.WriteLine("Prašič pravi: oink oink");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Prasic mojPrasic = new Prasic(); // Ustvari objekt Prasic
        mojPrasic.zvokZivali();  // Pokliče abstraktno metodo
        mojPrasic.spi();  // Pokliče navadno metodo
    }
}


//////////////////////////////////////////////////////////////////////////////////////
// Vmesniki (Interfaces):
// Vmesniki so podobni abstraktnim razredom,
// vendar lahko razredi implementirajo več vmesnikov.
// Ne rabi imeti črke I pred imenom, to je za lažjo prepoznavnost.

public interface IOseba
{
    string Ime { get; set; }
    int Starost { get; set; }

    void Pozdravi();
}

public class Student : IOseba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
    public int Letnik { get; set; }

    public void Pozdravi()
    {
        Console.WriteLine("Zdravo, " + Ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Strukti (Structs):
// Strukti so podobni razredom, vendar so vrednostni tipi
// in jih običajno uporabljamo za majhne podatkovne strukture.

public struct Coords
{
    public double X { get; }
    public double Y { get; }
    
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"({X}, {Y})";
}
