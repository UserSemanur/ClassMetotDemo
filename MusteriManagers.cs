using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
      class MusteriManagers
    {
       public  void MusteriGoruntule(Musteri musteri )
        {

            Console.WriteLine("Müşterinin adı :  " + musteri.Ad + "\n" +"Müşterinin Soyadı : "+ musteri.Soyad + "\n"+ "Müşterinin Maaşı : " +musteri.maas );

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " kaydı başarıyla silindi.");
        }


    }
}
