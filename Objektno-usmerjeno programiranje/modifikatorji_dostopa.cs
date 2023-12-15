// Public (javno):
// Če deklarirate spremenljivko ali metodo kot "public",
// je ta dostopna iz katerega koli drugega razreda.

public class Oseba {
    public string Ime;
    public void PredstaviSe() {
        Console.WriteLine("Pozdravljen, moje ime je " + Ime + "!");
    }
}

// Razred Oseba je sedaj dostopen iz katerega koli drugega razreda.
public class Program {
    static void Main() {
        Oseba oseba = new Oseba();
        oseba.Ime = "Janez";
        oseba.PredstaviSe();
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Private (zasebno):
// Če deklarirate spremenljivko ali metodo kot "private",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana.

class Oseba
{
    private readonly string _ime = "Ime, Priimek";
    private readonly double _placa = 100.0;

    public string GetIme()
    {
        return _ime;
    }

    public double Placa
    {
        get { return _placa; }
    }
}

class PrivateTest
{
    static void Main()
    {
        var oseba = new Oseba();

        // Podatkovni člani so nedostopni (zasebni), zato
        // do njih ni mogoče dostopati na ta način:
        //    string n = e._ime;
        //    double s = e._placa;

        // '_ime' je indirektno dostopno preko metode
        string ime = oseba.GetIme();

        // '_placa' je indirektno dostopna preko lastnosti
        double placa = oseba.Placa;
    }
}

//////////////////////////////////////////////////////////////////////////////////////

public class Oseba {
    private string Ime;
    private void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

// Spremenljivka ime in metoda Pozdravi() sta sedaj dostopni samo iz razreda Oseba.
public class Program {
    static void Main() {
        Oseba oseba = new Oseba();
        oseba.Ime = "Janez"; // Napaka!
        oseba.Pozdravi(); // Napaka!
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Protected (zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "protected",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz podrazredov tega razreda.

public class Oseba {
    protected string Ime;
    protected void RazkrijIme() {
        Console.WriteLine("Moje ime je " + Ime + "!");
    }
}

// Spremenljivka ime in metoda Pozdravi() sta sedaj dostopni samo iz razreda Oseba in njegovih podrazredov.
public class Student : Oseba {
    public void Pozdravi() {
        Console.WriteLine("Zdravo!");
    }
}

// Razred Student je podrazred razreda Oseba.
public class Program {
    static void Main() {
        Student student = new Student();
        student.Ime = "Janez"; // Napaka!
        student.RazkrijIme(); // Napaka!
        student.Pozdravi(); // OK!
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Internal (notranje):
// Če deklarirate spremenljivko ali metodo kot "internal",
// je ta dostopna samo iz trenutnega projekta (assembly).

public class Oseba {
    internal string Ime;
    internal void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Protected Internal (zaščiteno notranje):
// Če deklarirate spremenljivko ali metodo kot "protected internal",
// je ta dostopna iz trenutnega projekta (assembly) in iz podrazredov tega razreda (assembly).

public class Oseba {
    protected internal string Ime;
    protected internal void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Private Protected (zasebno zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "private protected",
// je ta dostopna samo iz trenutnega projekta (assembly) in iz podrazredov tega razreda (assembly).

public class Oseba {
    private protected string Ime;
    private protected void Pozdravi() {
        Console.WriteLine("Pozdravljen!");
    }
}