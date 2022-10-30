 namespace _4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr =new Ogrenci();
            ogr.AdiSoyadi = "Büşra";
            ogr.Cinsiyet = "K";
            ogr.Yas = 18;
            ogr.OgrenciNo = 789;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdiSoyadi = "Onur";
            ogr1.Cinsiyet = "E";
            ogr1.Yas = 34;
            ogr1.OgrenciNo = 456;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.AdiSoyadi = "Celalettin";
            ogr2.Cinsiyet = "E";
            ogr2.Yas = 34;
            ogr2.OgrenciNo = 123;

            Egitmen egitmen = new Egitmen();
            egitmen.AdiSoyadi = "Ekrem";
            egitmen.Cinsiyet = "E";
            egitmen.Yas = 34;
            egitmen.Maas = 500;

            Console.WriteLine($"{ogr.AdiSoyadi}, {ogr.Cinsiyet}, {ogr.Yas}, {ogr.OgrenciNo}");
            Console.WriteLine($"{egitmen.AdiSoyadi} {egitmen.Maas}");
            
            Console.WriteLine("*******************************");
            
            Insan i = egitmen;
            Insan i1 = ogr1;

            Console.WriteLine(i.AdiSoyadi);
            Console.WriteLine(i1.AdiSoyadi);
            Console.WriteLine("********************************");
            BilgileriniYaz(ogr);
            BilgileriniYaz(ogr1);
            BilgileriniYaz(ogr2);
            BilgileriniYaz(egitmen);

              

            Console.ReadKey();
        }

        static void BilgileriniYaz(Insan insan)
        {
            Console.WriteLine($"{insan.AdiSoyadi} - {insan.Yas} ");

            if (insan is Ogrenci)
            {
                Ogrenci o = (Ogrenci)insan;
                Console.WriteLine(o.OgrenciNo);
            }
            else if (insan is Egitmen)
            {
                Egitmen e= (Egitmen)insan;
                Console.WriteLine(e.Maas);
            }
            Console.WriteLine("========================");
        }
    }
}