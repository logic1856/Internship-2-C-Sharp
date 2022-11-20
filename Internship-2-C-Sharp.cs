using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;

var igraci = new Dictionary<string, int>();
var pozicije=new Dictionary<string, string>();
var sviStrijelci = new Dictionary<string, int>();
var ut=new List<int>();
var ut2=new List<string>();
var pocetnapostava=new List<string>();
var sviigraci=new List<string>();
var ekipe=new List<int>() { 0,0,0,0};
var tablica=new List<string>() { "Hrvatska","Meksiko","Argentina","Portugal"};
var utakmice = new List<int>() { 1234, 1324, 1423, 1234, 1324, 1423 };
int utakmicc = -1;
var golrazlika = new Dictionary<string, int>();
golrazlika.Add("Hrvatska", 0);
golrazlika.Add("Meksiko", 0);
golrazlika.Add("Argentina", 0);
golrazlika.Add("Portugal", 0);
var svirez = new List<string>();
var svaim = new List<int>();
var svirez2 = new List<string>();
var svaim2 = new List<int>();
igraci.Add("Luka Modric", 90);
pozicije.Add("Luka Modric", "MF");
igraci.Add("Mateo Kovacic", 84);
pozicije.Add("Mateo Kovacic", "MF");
igraci.Add("Lovro Majer", 80);
pozicije.Add("Lovro Majer", "MF");
igraci.Add("Dominik Livakovic", 80);
pozicije.Add("Dominik Livakovic", "GK");
igraci.Add("Josko Gvardiol", 81);
pozicije.Add("Josko Gvardiol", "DF");
igraci.Add("Dejan Lovren", 78);
pozicije.Add("Dejan Lovren", "DF");
igraci.Add("Duje Caleta Car", 78);
pozicije.Add("Duje Caleta Car", "DF");
igraci.Add("Josip Juranovic", 75);
pozicije.Add("Josip Juranovic", "DF");
igraci.Add("Ivan Rakitic", 82);
pozicije.Add("Ivan Rakitic", "FW");
igraci.Add("Ivan Perisic", 84);
pozicije.Add("Ivan Perisic", "FW");
igraci.Add("Andrej Kramaric", 82);
pozicije.Add("Andrej Kramaric", "FW");
igraci.Add("Josip Sutalo", 75);
pozicije.Add("Josip Sutalo", "DF");
igraci.Add("Luka Ivanusec", 75);
pozicije.Add("Luka Ivanusec", "MF");
igraci.Add("Marko Pjaca", 75);
pozicije.Add("Marko Pjaca", "MF");
igraci.Add("Nikola Kalinic", 74);
pozicije.Add("Nikola Kalinic", "GK");
igraci.Add("Ivo Grbic", 74);
pozicije.Add("Ivo Grbic", "GK");
foreach (var k in igraci.Keys)
{
    sviigraci.Add(k);
}
var uzlazno = new List<int>();
var uzlaznoi = new List<string>();
var igraci2 = new List<string>();
igraci2.Add("luka puco");
var p = new List<int>() { 1, 4, 3, 3 };
var p2 = new List<int>() { 1, 4, 3, 3 };
var p3 = new List<string>() { "GK", "DF", "MF", "FW" };
var rnd = new Random();
var str=new List<string>();
void pocetniIzbornik()
{
    Console.Clear();
    Console.WriteLine("1 - Odradi trening \n2 - Odigraj utakmicu \n3 - Statistika \n4 - Kontrola igraca \n0 - Izlaz iz aplikacije");
    var izbor=int.Parse(Console.ReadLine());
    switch (izbor)
    {
        case 1:
            odradiTrening();
            break;
        case 2:
            odigrajUtakmicu();
            break;
        case 3:
            statistika();
            break;
        case 4:
           kontrolaIgraca();
            break;
        case 0:
            //izlazIzAplikacije();
            break;
    }
}
void kontrolaIgraca()
{
    Console.Clear();
    Console.WriteLine("1-unos novog igraca\n2-brisanje igraca\n3-uredivanje igraca\n0-izlaz");
    int ulaz2 = int.Parse(Console.ReadLine());
    switch (ulaz2)
    {
        case 1:
            unosnovog();
            break;
        case 2:
            brisi();
            break;
        case 3:
            uredi();
            break;
    }
    Console.WriteLine("\n0 - izlaz na pocetni izbornik");
    int iz = int.Parse(Console.ReadLine());
    if (iz == 0)
    {
        ut.Clear();
        ut2.Clear();
        pocetnapostava.Clear();

        pocetniIzbornik();
    }

}
void uredi()
{
    Console.Clear();
    Console.WriteLine("1-uredi ime i prezime igraca\n2-uredi poziciju igraca\n3-uredi rating igraca igraca");
    int ulaz2 = int.Parse(Console.ReadLine());
    switch (ulaz2)
    {
        case 1:
            urediime();
            break;
        case 2:
            uredipoziciju();
            break;
        case 3:
            uredirating();
            break;
    }
    Console.WriteLine("\n0 - izlaz na pocetni izbornik");
    int iz = int.Parse(Console.ReadLine());
    if (iz == 0)
    {
        ut.Clear();
        ut2.Clear();
        pocetnapostava.Clear();

        pocetniIzbornik();
    }
}
void uredirating()
{
    Console.Clear();
    Console.WriteLine("unesite ime i prezime igraca kojem zelite promjeniti rating");
    string ime = Console.ReadLine();
    Console.WriteLine("unesite novi rating");
    int nova = int.Parse(Console.ReadLine());
    igraci[ime] = nova;
}
void uredipoziciju()
{
    Console.Clear();
    Console.WriteLine("unesite ime i prezime igraca kojem zelite promjeniti poziciju");
    string ime = Console.ReadLine();
    Console.WriteLine("unesite novu poziciju");
    string nova = Console.ReadLine();
    pozicije[ime] = nova;
}
void urediime()
{
    Console.Clear();
    Console.WriteLine(" unesite ime i prezime igraca kojem zelite promjeniti ime i prezime ");
    string ime = Console.ReadLine();
    Console.WriteLine(" unesite novo ime i prezime igracu");
    string novo = Console.ReadLine();
    int rating = igraci[ime];
    string poz = pozicije[ime];
    if (sviStrijelci[ime] > 0)
    {
        int brojgolova = sviStrijelci[ime];
        sviStrijelci.Remove(ime);
        sviStrijelci.Add(novo, brojgolova);
    }
    igraci.Remove(ime);
    pozicije.Remove(ime);
    igraci.Add(novo, rating);
    pozicije.Add(novo, poz);
    for(int i=0; i < sviigraci.Count; i++)
    {
        if (sviigraci[i] == ime)
        {
            sviigraci[i] = novo;
        }
    }
}
void brisi()
{
    Console.Clear();
    Console.WriteLine("unesi ime i prezime igraca kojeg zelis obrisati");
    string obrisi = Console.ReadLine();
    igraci.Remove(obrisi);
    pozicije.Remove(obrisi);
}
void unosnovog()
{
    Console.Clear();
    Console.WriteLine("unesi ime i prezime novog igraca");
    string novi=Console.ReadLine();
    Console.WriteLine("unesi poziciju novog igraca");
    string novipozicija = Console.ReadLine();
    Console.WriteLine("unesi rating novog igraca");
    int novirating = int.Parse(Console.ReadLine());
    igraci.Add(novi, novirating);
    pozicije.Add(novi, novipozicija);
    sviigraci.Add(novi);
}
void statistika()
{
    Console.Clear();
    Console.WriteLine("1-Ispis svih igraca");
    int ulaz=int.Parse(Console.ReadLine());
    if (ulaz == 1)
    {
        Console.Clear();
        Console.WriteLine("1-Ispis onako kako su spremljeni\n2-Ispis po rating uzlazno\n3-ispis po rating silazno\n4-ispis igraca po imenu i prezimenu\n5-ispis igraca po ratingu\n6-ispis igraca po poziciji\n7-ispis trenutno prvih 11 igraca\n8-ispis strijelaca i koliko golova imaju\n9-ispis svih rezultata ekipe\n10-ispis rezultata svih ekipa\n11-ispis tablice grupe");
        int ulaz2=int.Parse(Console.ReadLine());
        switch (ulaz2)
        {
            case 1:
                kakoSuSpremljeni();
                break;
            case 2:
                ratingg();
                ratingUzlazno();
                break;
            case 3:
                ratingg();
                ratingSilazno();
                break;
            case 4:
                poimenu();
                break;
            case 5:
                poratingu();
                break;
            case 6:
                popoziciji();
                break;
            case 7:
                prvih11();
                break;
            case 8:
                ispisStrijelaca();
                break;
            case 9:
                ispisrezultataekipe();
                break;
            case 10:
                ispissvihrez();
                break;
            case 11:
                ispistablice();
                break;

        }
        Console.WriteLine("\n0 - izlaz na pocetni izbornik");
        int iz = int.Parse(Console.ReadLine());
        if (iz == 0)
        {
            ut.Clear();
            ut2.Clear();
            pocetnapostava.Clear();

            pocetniIzbornik();
        }
    }
    else
    {
        pocetniIzbornik();
    }
}
void ispistablice()
{
    var sor = new List<int>();
    var sor2=new List<string>();
    for(int i = 0; i < ekipe.Count; i++)
    {
        sor.Add(ekipe[i]);
        sor2.Add(tablica[i]);
    }
    for(int i = 0; i < sor.Count; i++)
    {
        for(int j=i;j<sor.Count; j++)
        {
            if (sor[i] < sor[j])
            {
                int e = sor[i];
                sor[i] = sor[j];
                sor[j] = e;
                string ee = sor2[i];
                sor2[i] = sor2[j];
                sor2[j] = ee;
            }
        }
    }
    Console.WriteLine("ime" + " " +"mjesto" + " " + "bodovi" + " " + "GR" );
    for (int i = 0; i < sor.Count; i++)
    {
        Console.WriteLine(sor2[i] +" "+ (i+1)+" "+sor[i]+" " + golrazlika[sor2[i]]+"\n");
    }
}
void ispissvihrez()
{
    Console.Clear();
    for (int i = 0; i < svaim.Count; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write("\n" + svirez[i] + " : " + svirez[i + 1] + " " + svaim[i] + " : " + svaim[i + 1]);
            Console.Write("\n" + svirez2[i] + " : " + svirez2[i + 1] + " " + svaim2[i] + " : " + svaim2[i + 1]);
        }

    }
    
}
void ispisrezultataekipe()
{
    Console.Clear();
    for(int i = 0; i < svaim.Count; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write("\n"+svirez[i]+" : " + svirez[i+1]+" " + svaim[i]+" : " + svaim[i+1]);

        }
        
    }

}
void ispisStrijelaca()
{
    Console.Clear();
    foreach(var k in sviStrijelci.Keys)
    {
        Console.WriteLine(k+" "+sviStrijelci[k]);
    }
}
void prvih11()
{
    Console.Clear();
    utakmica();
    if (provjera() == 1)
    {
        for (int i = 0; i < p2.Count; i++)
        {
            int brojac = p2[i];

            for (int t = (ut2.Count) - 1; t >= 0; t--)
            {
                if (pozicije[ut2[t]] == p3[i] && brojac > 0)
                {
                    pocetnapostava.Add(ut2[t]);
                    brojac -= 1;
                }
            }

        }
    }
    for(int i = 0; i < pocetnapostava.Count; i++)
    {
        Console.WriteLine(pocetnapostava[i]);
    }
    pocetnapostava.Clear();
    ut2.Clear();
    ut.Clear();
}
void popoziciji()
{
    Console.Clear();
    String ime = Console.ReadLine();
    foreach(var k in pozicije.Keys)
    {
        if (pozicije[k] == ime)
        {
            Console.WriteLine(k);
        }
    }
}
void poratingu()
{
    Console.Clear();
    int ime = int.Parse(Console.ReadLine());
    foreach (var k in igraci.Keys)
    {
        if (igraci[k] == ime)
        {
            Console.WriteLine(k);
        }
    }
}
void poimenu()
{
    Console.Clear();
    String ime = Console.ReadLine();
    Console.WriteLine(ime + " " + pozicije[ime] + " " + igraci[ime]);
}
void ratingg()
{
    Console.Clear();
    foreach(var k in igraci.Keys)
    {
        uzlazno.Add(igraci[k]);
        uzlaznoi.Add(k);
    }
    for(int i=0; i < uzlazno.Count; i++)
    {
        for(int j=i; j < uzlazno.Count; j++)
        {
            if (uzlazno[i] > uzlazno[j])
            {
                int e=uzlazno[i];
                uzlazno[i]=uzlazno[j];
                uzlazno[j] = e;
                string ee = uzlaznoi[i];
                uzlaznoi[i] = uzlaznoi[j];
                uzlaznoi[j] = ee;
            }
        }
        
    }
}
void ratingUzlazno()
{
    for (int i = 0; i < uzlazno.Count; i++)
    {
        Console.WriteLine(uzlaznoi[i] + " " + uzlazno[i]);
    }
    uzlazno.Clear();
    uzlaznoi.Clear();
}
void ratingSilazno()
{
    for (int i =uzlazno.Count-1; i >=0; i--)
    {
        Console.WriteLine(uzlaznoi[i] + " " + uzlazno[i]);
    }
    uzlazno.Clear();
    uzlaznoi.Clear();
}
void kakoSuSpremljeni()
{
    Console.Clear();
    for(int k=0;k<sviigraci.Count;k++)
    {
        Console.WriteLine(sviigraci[k]);
    }
}
void odigrajUtakmicu()
{
    Console.Clear();
    utakmicc += 1;
    if (utakmicc >= 6)
    {
        Console.WriteLine("Odigrale su se sve utakmice");
        pocetniIzbornik();
        return;
    }
    int x = 0;
    foreach(var k in igraci.Keys)
    {
        x += 1;
    }
    if (x < 11)
    {
        Console.WriteLine("Nemoze se pokrenuti utakmica jer nema dovoljno igraca");
    }
    else
    {
        utakmica();
        if (provjera() == 1)
        {
            for(int i = 0; i < p2.Count; i++)
            {
                int brojac = p2[i];
                
                    for(int t=(ut2.Count)-1; t>=0; t--)
                    {
                        if (pozicije[ut2[t]] == p3[i] && brojac > 0)
                        {
                            pocetnapostava.Add(ut2[t]);
                            brojac -= 1;
                        }
                    }
                
            }
            int rez1 = rnd.Next() % 11;
            int rez2 = rnd.Next() % 11;
            int rez3=rnd.Next() % 11;
            int rez4=rnd.Next() % 11;
            int xx = utakmice[utakmicc];
                Console.Write(tablica[xx%10-1]+" ");
                xx /= 10;
                Console.Write(tablica[xx % 10-1] + " ");
                Console.Write(rez4 + " : " + rez3+"\n");
                xx /= 10;
                Console.Write(tablica[xx % 10-1] + " ");
                xx /= 10;
                Console.Write(tablica[xx % 10 - 1] + " ");
                xx /= 10;
                Console.Write(rez2+" : "+rez1 + "\n");
            int yy=utakmice[utakmicc];
            yy /= 100;
            svaim.Add(rez1);
            svaim.Add(rez2);
            svirez.Add(tablica[(yy / 10) % 10-1]);
            svirez.Add(tablica[yy % 10-1]);
            int yyy = utakmice[utakmicc];
            svaim2.Add(rez3);
            svaim2.Add(rez4);
            svirez2.Add(tablica[(yyy / 10) % 10 - 1]);
            svirez2.Add(tablica[yyy % 10 - 1]);
            if (rez3 > rez4)
            {
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez4 - rez3;
                utakmice[utakmicc] /= 10;
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez3 - rez4;
                ekipe[utakmice[utakmicc] % 10 - 1] += 3;
                utakmice[utakmicc] /= 10;

            }
            else if (rez3 == rez4)
            {
                ekipe[utakmice[utakmicc] % 10-1] += 1;
                utakmice[utakmicc] /= 10;
                ekipe[utakmice[utakmicc] % 10-1] += 1;
                utakmice[utakmicc] /= 10;
            }
            else
            {
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez4 - rez3;
                ekipe[utakmice[utakmicc] % 10-1] += 3;
                utakmice[utakmicc] /= 10;
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez3 - rez4;
                utakmice[utakmicc] /= 10;
            }
            if (rez1 > rez2)
            {
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez2 - rez1;
                utakmice[utakmicc] /= 10;
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez1 - rez2;
                ekipe[utakmice[utakmicc] % 10-1] += 3;
                utakmice[utakmicc] /= 10;

            }
            else if (rez1 == rez2)
            {
                ekipe[utakmice[utakmicc] % 10-1] += 1;
                utakmice[utakmicc] /= 10;
                ekipe[utakmice[utakmicc] % 10-1] += 1;
                utakmice[utakmicc] /= 10;
            }
            else
            {
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez2 - rez1;
                ekipe[utakmice[utakmicc] % 10-1] += 3;
               utakmice[utakmicc]/= 10;
                golrazlika[tablica[utakmice[utakmicc] % 10 - 1]] += rez1 - rez2;
                utakmice[utakmicc] /= 10;
            }
            for (int i = 0; i < rez1; i++)
            {
                string strijelac = pocetnapostava[rnd.Next() % 11];
                int u = 0;
                for (int j = 0; j < str.Count; j++)
                {
                    if (strijelac == str[j])
                    {
                        u += 1;
                    }
                }
                if (u == 0)
                {
                    str.Add(strijelac);
                }
                int uu = 0;
                foreach (var k in sviStrijelci.Keys)
                {
                    if (k == strijelac)
                    {
                        uu = 1;
                        sviStrijelci[k] += 1;
                    }
                }
                if (uu == 0)
                {
                    sviStrijelci.Add(strijelac, 1);
                }
            }
            for(int i=0;i<str.Count; i++)
            {
                
                igraci[str[i]] = igraci[str[i]] + igraci[str[i]] * 5 / 100;
            }
            if (rez1 > rez2)
            {
                foreach(var k in igraci.Keys)
                {
                    igraci[k]= igraci[k] + igraci[k] * 2 / 100;
                }
            }
            else
            {
                foreach (var k in igraci.Keys)
                {
                    igraci[k] = igraci[k] - igraci[k] * 2 / 100;
                }
            }
            Console.WriteLine("Nasa ekipa je postigla " + rez1 + " pogotka a protivnicka " + rez2);
            Console.WriteLine("Strijelci nase ekipe su: ");
            for(int i=0;i<str.Count; i++)
            {
                Console.WriteLine(str[i]);
            }
            str.Clear();
        }
        else
        {
            Console.WriteLine("Nije moguce odigrati utakmicu jer nema dovoljno igraca na nekoj poziciji");
        }
    }
    Console.WriteLine("0 - izlaz na pocetni izbornik");
    int iz = int.Parse(Console.ReadLine());
    if(iz == 0)
    {
        ut.Clear();
        ut2.Clear();
        pocetnapostava.Clear();

        pocetniIzbornik();
    }
}
int provjera()
{
    for(int i = 0; i < ut.Count; i++)
    {
        if (pozicije[ut2[i]] == "GK")
        {
            p[0] -= 1;
        }
        else if(pozicije[ut2[i]] == "DF")
        {
            p[1] -= 1;
        }
        else if (pozicije[ut2[i]] == "MF")
        {
            p[2] -= 1;
        }
        else if(pozicije[ut2[i]] == "FW")
        {
            p[3] -= 1;
        }
    }
    if (p[0]>0 || p[1]>0 || p[2]>0 || p[3] > 0)
    {
        p.Clear();
        p.Add(1);
        p.Add(4);
        p.Add(3);
        p.Add(3);
        return 0;
    }
    p.Clear();
    p.Add(1);
    p.Add(4);
    p.Add(3);
    p.Add(3);
    return 1;
}
void utakmica()
{
    foreach(var k in igraci.Keys)
    {
        ut.Add(igraci[k]);
        ut2.Add(k);
    }
    for(int i = 0; i < ut.Count; i++)
    {
        for(int j=i;j< ut.Count; j++)
        {
            if (ut[i] > ut[j])
            {
                int x = ut[i];
                ut[i] = ut[j];
                ut[j] = x;
                var y = ut2[i];
                ut2[i] = ut2[j];
                ut2[j] = y;

            }
        }
    }

    
}
void odradiTrening()
{
    Console.Clear();
    foreach(var k in igraci.Keys)
    {
        Console.Write(k+" "+igraci[k]+" ");
        double x=(double)igraci[k]*(rnd.Next()%11-5)/100;
        igraci[k] = igraci[k] + (int)x;
        Console.Write(igraci[k]+"\n");
        
    }
    Console.WriteLine("0 - izlaz na pocetni izbornik");
    int unos = int.Parse(Console.ReadLine());
    if(unos == 0)
    {
        pocetniIzbornik();
    }
    
}

pocetniIzbornik();
