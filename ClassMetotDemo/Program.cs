using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Nida";
            musteri1.Soyadi = "Erdem";
            musteri1.Cinsiyet = "Kadın";
            musteri1.Yas = 26;
            musteri1.Bakiye = 2500;


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayaz";
            musteri2.Soyadi = "Dolu";
            musteri2.Cinsiyet = "Erkek";
            musteri2.Yas = 32;
            musteri2.Bakiye = 3000;


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Erva";
            musteri3.Soyadi = "Bulut";
            musteri3.Cinsiyet = "Kadın";
            musteri3.Yas = 23;
            musteri3.Bakiye = 500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Cinsiyet);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Bakiye);
            }


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Liste(musteri3);


            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);




        }
    }
}
