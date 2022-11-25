using System;
using System.Linq.Expressions;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 11111;
                musteri1.Tc = 11111111111;
                musteri1.AdiSoyadi = "Bahar Ceylan";
                musteri1.Yasi = 22;
                musteri1.Sehir = "İzmir";
                musteri1.Meslek = "Öğrenci";
                musteri1.Maas = 0;
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.Id = 22222;
                musteri2.Tc = 22222222222;
                musteri2.AdiSoyadi = "Yeşua Mert Dügeroğlu";
                musteri2.Yasi = 22;
                musteri2.Sehir = "İstanbul";
                musteri2.Meslek = "Barista";
                musteri2.Maas = 90000;
            }
            Musteri musteri3 = new Musteri();
            {
                musteri3.Id = 33333;
                musteri3.Tc = 33333333333;
                musteri3.AdiSoyadi = "Fatma Ceylan";
                musteri3.Yasi = 32;
                musteri3.Sehir = "Adana";
                musteri3.Meslek = "Avukat";
                musteri3.Maas = 30000;

            }
            Musteri[] musteriList = new Musteri[3] { musteri1, musteri2, musteri3 };

            MusteriManager musteriIslemleri = new MusteriManager();

            musteriIslemleri.Listele(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Listele(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Listele(musteri3);
            Console.WriteLine("-----------------");

            musteriIslemleri.Ekle(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Ekle(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Ekle(musteri3);
            Console.WriteLine("-----------------");

            musteriIslemleri.Sil(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Sil(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Sil(musteri3);
            Console.WriteLine("-----------------");

        }
    }
}