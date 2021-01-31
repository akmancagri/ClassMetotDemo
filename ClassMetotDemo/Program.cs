using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mahmut";
            musteri1.Soyadi = "Tuncer";
            musteri1.HesapTuru = "Vadeli";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Hayrettin";
            musteri2.Soyadi = "Bağrıyanık";
            musteri2.HesapTuru = "Vadesiz";

            Console.WriteLine("-----Müşteri Listeleme-----");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);

            Console.WriteLine("-----Müşteri Ekleme-----");

            musteriManager.Add("Aziziye", "Değişik", "Döviz");

            Console.WriteLine("-----Müşteri Silme-----");

            musteriManager.Delete("Polat", "Alemdar", "Altın");

        }
    }
}
