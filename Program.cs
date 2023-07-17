using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.ID = 13;
            musteri1.Ad = "Almuni";
            musteri1.Soyad = "Meow";
            musteri1.maas = 35000;


            Musteri musteri2 = new Musteri();

            musteri2.ID = 14;
            musteri2.Ad = "Semanur";
            musteri2.Soyad = "Meow";
            musteri2.maas = 50000;

            MusteriManagers musteriManagers = new MusteriManagers();

            musteriManagers.MusteriGoruntule(musteri1);
            musteriManagers.Sil(musteri1);
            musteriManagers.MusteriGoruntule(musteri2);
            musteriManagers.Sil(musteri2);


        }
    }
}