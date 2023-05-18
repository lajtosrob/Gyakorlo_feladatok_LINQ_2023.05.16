using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {


        List<int> napiCsapadek = new List<int>() { 15, 0,  20, 1,  25, 2,  30, 3,  12, 4,  14, 5,  16, 2, 18, 1, 20, 2, 29, 3, 11, 0, 27, 3, 19, 2, 25, 1, 17, 2, 23, 1, 13, 2, 9 };

        List<string> versenyzok = new List<string>() { "Kovács János", "Kiss Dávid", "Tóth Sándor György", "Szabó Béla Tamás", "Lakatos Géza Vajk", "Imrédy Béla", "Kádár János", "Rákosi Mátyás", "Bárdossy László", "Teleki Pál", "Bethlen István", "Kun Béla Vajk", "Bodnár Dávid", "Szuper Béla" };

        List<double> maxHofok = new List<double>() { 15, 0, 20, 1, 25, 2, 30, 3, 12, 4, 14, 5, 16, 2, 18, 1, 20, 2, 29, 3, 11, 0, 27, 3, 19, 2, 25, 1, 17, 2, 23, 1, 13, 2, 9 };

        List<string> diakok = new List<string>() { "Kovács János", "Kiss Dávid", "Tóth Sándor György", "Szabó Béla Tamás", "Bodnár Dávid", };

        //   1) Hány olyan nap volt, amikor 20 fok feletti hőmérsékletet mértek? (2p)

        Console.WriteLine("1. feladat: 20 fok feletti hőmérséklet: " + napiCsapadek.Count(x => x > 20) + "nap");

        // 2) Hozzon létre egy új, hőfok szerint csökkenően rendezett listát! (3p)

        List<int> ujNapiCsapadek = new List<int>();
        ujNapiCsapadek = napiCsapadek.Select(x => x).OrderBy(x => x).ToList();
        Console.Write("2. feladat: Hőfok szerint rendezett lista: ");
        ujNapiCsapadek.ForEach(x => Console.Write(x + ", "));
        Console.WriteLine();

        // 3) Hány olyan diák van, akiknek két keresztneve van? (3p)

        Console.Write("3. feladat: Két keresztnevű diákok: ");
        Console.WriteLine(diakok.Count(x => x.Split(" ").Length == 3));

        // 4) Írassa képernyőre foreach vezérlési szerkezet segítségével azoknak a diákoknak a neveit, akik nevének hossza meghaladja a 15 karaktert.A kiíratás a nevek hossza szerint növekedve történjen! (5p)

        List<string> hosszuKeresztnev = diakok.Where(n => n.Length > 15).ToList();
        Console.Write("4. feladat: 15 karakternél hosszabb nevű diákok: ");
        hosszuKeresztnev.ForEach(x => Console.Write(x + ", "));
        
        Console.WriteLine();

        // 5) Hány olyan nap volt, amikor több mint 10mm eső esett? (2p)

        Console.Write("5. feladat: Több mint 10mm esős napok száma: " + napiCsapadek.Count(x => x >= 10) );

        Console.WriteLine();

        // 6) Rendezze csapadékérték szerint csökkenően a listát! (2p)

        Console.WriteLine("6. feladat: Csökkenőérték szerinti csapadéklista: ");
        napiCsapadek = napiCsapadek.OrderByDescending(x => x).ToList();
        napiCsapadek.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();

        // 7) Készítsen egy új listát aligesett néven, amely a 3mm alatti csapadékértékeket tartalmazza. (3p)

        List<int> aligesett = napiCsapadek.Where(x => x < 3).ToList();

        Console.Write("7. feladat: Alig esett lista: ");
        aligesett.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();

        // !!! 8) Rendezze a versenyzőket nevük karakterszáma szerint növekvő sorrendben, azon belül az azonos hosszúságú neveket pedig abc sorrend szerint növekedve! (4p)

        List<string> versenyzokRendezett = versenyzok.OrderBy(x => x.Length).ThenBy(x => x).ToList();
        Console.Write("8. feladat: Versenyzők karakterszám és ABC sorrend szerint rendezett lista: ");
        versenyzokRendezett.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();

        // 9) Hány olyan nap volt, amikor nem eset eső? (2p)

        Console.Write("9. feladat: Nem esett eső: " + napiCsapadek.Count(x => x == 0) + "nap");

        Console.WriteLine();

        // 10) Készítsen egy új listát sokeso néven, amely az 5mm feletti csapadékértékeket tartalmazza. (3p)

        List<int> sokeso = napiCsapadek.Where(x => x > 5).ToList();

        Console.Write("10. feladat: Sokesős napok: ");
        sokeso.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();

        // 11) Listázza ki azoknak a versenyzőknek a nevét, akik keresztneve[Dávid] (4p)

        Console.Write("11. feladat: Versenyzők, akik keresztneve Dávid: ");
        List<string> vanBenneDavid =  versenyzok.Where(x => x.Contains("Dávid")).ToList();
        vanBenneDavid.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();

        // 12) Mekkora volt a legnagyobb hőmérsékletkülönbség a mérések között? (2p)

        maxHofok = maxHofok.OrderBy(x => x).ToList();
        Console.WriteLine("12.feladat: A legnagyobb hőmérsékletkülönbség: " + (maxHofok.Last() - maxHofok.First()));

        // 13) Mi volt az év során a második legmagasabb csapadékérték? (3p)

        napiCsapadek = napiCsapadek.OrderBy(x => x).ToList();
        Console.WriteLine("13. Második legmagasabb csapadékérték: " + napiCsapadek[1]);

        // 14) Mennyi volt az év során az átlagos csapadékmennyiség? (2p)

        Console.WriteLine("14. feladat: átlagos csapadékmennyiség: " + Math.Round(napiCsapadek.Average(x => x), 1) + "fok");

        // 15) Van-e a versenyzők között „Szuper Béla” nevű induló? (2p)
        
        Console.WriteLine(versenyzok.Any(x => x.Contains("Szuper Béla")) ? "Van Szuper Béla nevű versenyző" : "Nincs Szuper Béla nevű versenyző. ");

        // 16) Az év melyik napján(sorszám) esett utoljára 30mm feletti csapadék? (3p)

        Console.WriteLine("16. feladat: Utolsó 30mm feletti csapadék az év " + (napiCsapadek.FindLastIndex( x => x >= 30) + 1) + ". napján.");

        // 17) Hány különböző vezetéknevű diák van a listában? (4p)

        Console.WriteLine("17. feladat: Különböző vezetéknevű diákok száma: " + diakok.Select(diak => diak.Split(' ')[0]).Distinct().Count());

        // 18) Hogyan hívják a legelső olyan versenyzőt, akinek a nevében szerepel a „Vajk” szó? (3p)

        Console.WriteLine("18. feladat: Az első Vajk nevű versenyző: " + versenyzok.FirstOrDefault(x => x.Contains("Vajk")));

        // 19) Készítsen egy nevek listát, amelyben a diákoknak csak az első keresztnevük szerepel! (3p)

        List<string> nevek = diakok.Select(x => x.Split(' ')[1]).ToList();
        nevek.ForEach(x => Console.Write("19. feladat: nevek lista: " + x + ", "));

        Console.WriteLine();

        // 20) Készítsen egy angolul nevű listát fordított névrend szerint a Béla nevű versenyzőkről. (4p)

        List<string> angolul = versenyzok
            .Where(x => x.Contains("Béla"))
            .Select(x => x.Split(" ")[1] + " " + x.Split(" ")[0])
            .ToList();
        Console.Write("20. feladat: Béla nevű versenyzők \"angolul\" listája: ");
        angolul.ForEach(x => Console.Write(x + ", "));

        Console.WriteLine();
    }
}