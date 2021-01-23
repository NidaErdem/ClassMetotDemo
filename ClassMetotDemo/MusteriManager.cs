using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteriEkle)
        {
            Console.WriteLine("Müşteriniz Sisteme Eklenmiştir. : " + musteriEkle.Adi + " " + musteriEkle.Soyadi);
        }

        public void Liste(Musteri musteriListe)
        {
            Console.WriteLine("Müşterileriniz Listelenmiştir. -> " + musteriListe.Adi + " " + musteriListe.Soyadi + "-" + musteriListe.Cinsiyet + "-" + musteriListe.Yas + "-" + musteriListe.Bakiye);
        }

        public void Silme(Musteri musteriSilme)
        {
            Console.WriteLine("Müşteriniz Sistemden Silinmiştir. : " + musteriSilme.Adi + " " + musteriSilme.Soyadi);
        }


    }
}
