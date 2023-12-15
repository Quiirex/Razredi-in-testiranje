// Razredi (Classes):
// Razredi so temeljna enota OOP in predstavljajo modele objektov.

public class Oseba {
    public String ime;
    public int starost;
}

//////////////////////////////////////////////////////////////////////////////////////
// Lastnosti (Properties):
// Lastnosti so podatki, ki jih ima objekt.

public class Oseba {
    private String ime; // ime je lastnost
    private int starost; // starost je lastnost
}

//////////////////////////////////////////////////////////////////////////////////////
// Fieldi (Fields):
// Fieldi so (skoraj vedno) zasebni za razred in 
// dostopni prek metod get<Lastnost> in set<Lastnost>.
// Lastnosti zagotavljajo raven abstrakcije, 
// ki omogoča spreminjanje fieldov, 
// ne da bi vplivale na zunanji način, kako do njih dostopajo stvari, 
// ki uporabljajo vaš razred.

public class Razred {
    // to je field.  Je zaseben za razred in hrani dejanske podatke.
    private String _mojField;

    // to je lastnost. Ko do nje dostopate, uporablja osnovni field,
    // vendar izpostavi samo "pogodbo", na katero osnovni field ne bo vplival.
    public String getMojaLastnost() {
        return _mojField;
    }

    public void setMojaLastnost(String mojaLastnost) {
        this._mojField = mojaLastnost;
    }
}


//////////////////////////////////////////////////////////////////////////////////////
// Objekti (Objects): 
// Objekti so primerki razredov, ki dejansko obstajajo v programu. 
// Lahko ustvarimo več objektov istega razreda.

// Najprej potrebujemo razred:
public class Oseba {
    public String ime;
    public int starost;
}

// Nato ustvarimo objekt:

Oseba oseba1 = new Oseba();
oseba1.ime = "Janez";
oseba1.starost = 20;

// Nato uporabimo objekt:
public class Program {
    public static void main(String[] args) {
        Oseba oseba1 = new Oseba();
        oseba1.ime = "Janez";
        oseba1.starost = 20;

        System.out.println(oseba1.ime);
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Konstruktorji (Constructors):
// Konstruktorji so posebne metode razreda,
// ki se kličejo ob ustvarjanju objekta
// in omogočajo inicializacijo objekta.

public class Oseba {
    public String ime;
    public int starost;

    public Oseba(String ime, int starost) {
        this.ime = ime;
        this.starost = starost;
    }
}

// 'This' rezervirana beseda se uporablja za sklicevanje na trenutni objekt.

//////////////////////////////////////////////////////////////////////////////////////
// Encapsulacija (Encapsulation):
// Encapsulacija pomeni skrivanje podatkov razreda
// pred neposrednim dostopom
// ter zagotavljanje dostopa prek javnih vmesnikov (getters in setters).

public class Oseba {
    private String ime;
    private int starost;

    public String getIme() {
        return ime;
    }

    public void setIme(String ime) {
        this.ime = ime;
    }

    public int getStarost() {
        return starost;
    }

    public void setStarost(int starost) {
        this.starost = starost;
    }
}

// V industriji se uporablja Lombok, ki samodejno ustvari getterje in setterje.
import lombok.Getter;
import lombok.Setter;

@Getter // anotacija
@Setter // anotacija
public class Oseba {
    private String ime;
    private int starost;

    // Ne rabimo več pisati getterjev in setterjev.
}

//////////////////////////////////////////////////////////////////////////////////////
// Dedovanje (Inheritance):
// Dedovanje omogoča ustvarjanje novih razredov (podrazredov),
// ki podedujejo lastnosti in metode obstoječega razreda (nadrazreda).
// Podrazredi lahko nadgradijo ali spremenijo obstoječe lastnosti in metode.
// V Javi lahko razred deduje samo od enega razreda.

public class Oseba {
    public String ime;
    public int starost;
}

public class Student extends Oseba {
    public int letnik;
}

// Primer uporabe:
Student student1 = new Student();
student1.ime = "Janez";
student1.starost = 20;
student1.letnik = 2;

System.out.println(student1.ime);

//////////////////////////////////////////////////////////////////////////////////////
// Polimorfizem (Polymorphism):
// Polimorfizem omogoča, da različni objekti istega nadrazreda
// uporabljajo enake metode na svoj način.
// To omogoča prilagajanje vedenja razredov.

public class Oseba {
    public String ime;
    public int starost;

    public void pozdravi() {
        System.out.println("Pozdravljen, " + ime + "!");
    }
}

public class Student extends Oseba {
    public int letnik;

    @Override
    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}

//////////////////////////////////////////////////////////////////////////////////////
// Abstraktne razrede in metode (Abstract Classes and Methods):
// Abstraktne razrede in metode uporabljamo za definiranje skupnih lastnosti,
// vendar njihove dejanske implementacije odložimo na podrazrede.

public abstract class Oseba {
    public String ime;
    public int starost;

    public abstract void pozdravi();
}

public class Student extends Oseba {
    public int letnik;

    @Override
    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}

// Še en primer:
abstract class Zival {
    // Abstraktna metoda (nima telesa)
    public abstract void zvokZivali();

    // Navadna metoda
    public void spi() {
        System.out.println("Zzz");
    }
}

// Izpeljani razred (podeduje od Zival)
class Prasic extends Zival {
    @Override
    public void zvokZivali() {
        // Telo metode zvokZivali() je podano tukaj
        System.out.println("Prašič pravi: oink oink");
    }
}

public class Program {
    public static void main(String[] args) {
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

public interface IOseba {
    String getIme();
    int getStarost();

    void pozdravi();
}

public class Student implements IOseba {
    private String ime;
    private int starost;
    private int letnik;

    public String getIme() {
        return ime;
    }

    public int getStarost() {
        return starost;
    }

    public void pozdravi() {
        System.out.println("Zdravo, " + ime + "!");
    }
}