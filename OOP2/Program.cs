using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri()
            {
                MusteriNo = "58",
                Adi = "Emir",
                Soyadi = "Öztürk",
                TcNo = "12312312312",
                Id = 1
            };

            TuzelMusteri musteri2 = new TuzelMusteri()
            {
                Id = 2,
                MusteriNo = "14",
                SirketAdi = "Kodyazari",
                VergiNo = "1612123124",
            };

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
