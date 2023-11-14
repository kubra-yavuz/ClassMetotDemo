using System;
using ClassMetotDemo;

NewMethod();

static void NewMethod()
{
    Musteri musteri1 = new Musteri();

    musteri1.Id = 1;
    musteri1.Ad = "Ayşe Didar";
    musteri1.Soyad = "Yavuz";
    musteri1.Telefon = 12345;
    musteri1.Cinsiyet = "Kadın";

    Musteri musteri2 = new Musteri();

    musteri2.Id = 2;
    musteri2.Ad = "Kübra";
    musteri2.Soyad = "Yavuz";
    musteri2.Telefon = 2344;
    musteri2.Cinsiyet = "Kadın";

    Musteri musteri3 = new Musteri();

    musteri3.Id = 3;
    musteri3.Ad = "Halit";
    musteri3.Soyad = "Yavuz";
    musteri3.Telefon = 85769;
    musteri3.Cinsiyet = "Erkek";

    Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

    foreach (var Musteri in musteriler)
    {
        Console.WriteLine("Müşteri İsim ve Soyisim: " + Musteri.Ad + " " + Musteri.Soyad);
        Console.WriteLine("Müşteri İletişim: " + Musteri.Telefon);

        
    }

    MusteriManager musteriManager = new MusteriManager();
    musteriManager.MusteriEkle(musteri1);
    musteriManager.MusteriListele(musteri2);
    musteriManager.MusteriSil(musteri3);
    
}

Console.ReadLine();