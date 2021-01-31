using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı: "+musteri.Adi+" "+musteri.Soyadi);
            Console.WriteLine("Hesap Türü: " + musteri.HesapTuru);

        }

        public void Add(string musteriAdi, string musteriSoyadi, string hesapTuru)
        {
            Console.WriteLine("Tebrikler! Eklenen müşteri: "+musteriAdi+" "+musteriSoyadi);
        }

        public void Delete(string musteriAdi, string musteriSoyadi, string hesapTuru)
        {
            Console.WriteLine("Tebrikler! Silinen müşteri: " + musteriAdi + " " + musteriSoyadi);
        }
    }
}
