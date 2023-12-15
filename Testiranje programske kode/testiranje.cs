// Testiranje programske kode je ključni del razvoja programske opreme. 
// Omogoča nam, da preverimo, ali naša koda deluje pravilno in 
// ali izpolnjuje zahtevane specifikacije.

// Obstajajo štirje nivoji testiranja:
// Enotsko testiranje (unit testing) -> testiranje bele škatle, testiranje črne škatle, testiranje sive škatle, testiranje pokritosti kode, testiranje mutacij in regresijsko testiranje, 
// Integracijsko testiranje (integration testing) -> testiranje od zgoraj navzdol, testiranje od spodaj navzgor, sendvič testiranje, funkcionalno inkrementalno testiranje in regresijsko testiranje, 
// Sistemsko testiranje (system testing) -> funkcionalno testiranje, testiranje zmogljivosti, testiranje obremenitve, stresno testiranje, testiranje uporabnosti, varnostno testiranje, testiranje združljivosti, testiranje obnovitve in regresijsko testiranje, 
// Sprejemno testiranje (acceptance testing) -> alfa testiranje, beta testiranje, pogodbeno sprejemno testiranje.

// Enotsko testiranje je prav tako tehnika testiranja posameznih enot programske kode 
// (običajno so to metode) za določanje, ali pravilno delujejo. (Ga izvajamo mi)
// Spodaj je primer enotskega testa, kjer preverjamo, ali funkcija 'vecje' pravilno vrne večje število.

class Program
{
    static void Main(string[] args)
    {
        

        int prvo = 42; 
        int drugo = 7;
        int najvecje = vecje(prvo, drugo);
        test(najvecje); // Enotski test

        // Včasih želimo preveriti, kako se naša koda obnaša v nenavadnih ali nepričakovanih situacijah.
        // To imenujemo robni testi ali testi izjem. Spodaj je primer takšnega testa.

        test(33); // Robni test, ki pričakuje napako
    }

    static int vecje(int a, int b)
    {
        // Ta funkcija vrne večje od dveh števil.
        return a > b ? a : b;
    }

    static void test(int najvecje) 
    {
        // Ta funkcija preverja, ali je vrednost enaka 42. Če ni, izpiše "Napaka!?".
        // To je primer enotskega testa.
        if (42 != najvecje) 
            Console.Write("Napaka!?");
    }
}

// V realnem svetu bi uporabili knjižnico za enotsko testiranje, kot je npr. NUnit.
// Primer:
[TestFixture]
public class TestClass
{
    [Test]
    public void TestMethod()
    {
        int prvo = 42; 
        int drugo = 7;
        int najvecje = vecje(prvo, drugo);
        Assert.AreEqual(42, najvecje);
    }
}

// Integracijsko testiranje je postopek testiranja, kjer preverjamo,
// ali se različne komponente programske kode pravilno integrirajo. (Ga izvajamo mi)
// Več: https://www.guru99.com/integration-testing.html

// Sistemsko testiranje je postopek testiranja, kjer preverjamo,
// ali se celoten sistem pravilno obnaša. (Ga izvajamo mi)
// Več: https://www.guru99.com/system-testing.html

// Sprejemno testiranje je postopek testiranja, kjer stranka preverja,
// ali sistem izpolnjuje zahteve, ji jih je podala. (Ga izvaja stranka)
// Več: https://disbug.io/en/blog/acceptance-testing