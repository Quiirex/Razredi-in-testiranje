// Public (javno):
// Če deklarirate spremenljivko ali metodo kot "public",
// je ta dostopna iz katerega koli drugega razreda.

public class Oseba {
    public String ime;
    public void PredstaviSe() {
        System.out.println("Pozdravljen, moje ime je " + ime + "!");
    }
}

// Razred Oseba je sedaj dostopen iz katerega koli drugega razreda.
public class Main {
    public static void main(String[] args) {
        Oseba oseba = new Oseba();
        oseba.ime = "Janez";
        oseba.PredstaviSe();
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Private (zasebno):
// Če deklarirate spremenljivko ali metodo kot "private",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana.

class Oseba {
    private final String _ime = "Ime, Priimek";
    private final double _placa = 100.0;

    public String getIme() {
        return _ime;
    }

    public double getPlaca() {
        return _placa;
    }
}

class PrivateTest {
    public static void main(String[] args) {
        Oseba oseba = new Oseba();

        // Podatkovni člani so nedostopni (zasebni), zato
        // do njih ni mogoče dostopati na ta način:
        //    String n = e._ime;
        //    double s = e._placa;

        // '_ime' je indirektno dostopno preko metode
        String ime = oseba.getIme();

        // '_placa' je indirektno dostopna preko lastnosti
        double placa = oseba.getPlaca();
    }
}

//////////////////////////////////////////////////////////////////////////////////////

public class Oseba {
    private String ime;
    private void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

// Spremenljivka ime in metoda Pozdravi() sta sedaj dostopni samo iz razreda Oseba.
public class Main {
    public static void main(String[] args) {
        Oseba oseba = new Oseba();
        oseba.ime = "Janez"; // Napaka!
        oseba.Pozdravi(); // Napaka!
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Protected (zaščiteno):
// Če deklarirate spremenljivko ali metodo kot "protected",
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz podrazredov tega razreda.

public class Oseba {
    protected String ime;
    protected void RazkrijIme() {
        System.out.println("Moje ime je " + ime + "!");
    }
}

// Spremenljivka ime in metoda Pozdravi() sta sedaj dostopni samo iz razreda Oseba in njegovih podrazredov.
public class Student extends Oseba {
    public void Pozdravi() {
        System.out.println("Živjo!");
    }
}

// Razred Student je podrazred razreda Oseba.
public class Main {
    public static void main(String[] args) {
        Student student = new Student();
        student.ime = "Janez"; // Napaka!
        student.RazkrijIme(); // Napaka!
        student.Pozdravi(); // OK!
    }
}

//////////////////////////////////////////////////////////////////////////////////////

// Default (privzeto):
// Če deklarirate spremenljivko ali metodo brez modifikatorja dostopa,
// je ta dostopna samo iz razreda, v katerem je bila deklarirana,
// in iz razredov v istem paketu.

public class Oseba {
    String ime;
    void Pozdravi() {
        System.out.println("Pozdravljen!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////