using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri()
            {
                MusteriNo = "123",
                Adi = "Enes",
                Soyadi = "Yılmaz",
                TcNo = "123123123",
                Id = 1
            };

            TuzelMusteri musteri2 = new TuzelMusteri()
            {
                Id = 2,
                MusteriNo = "134",
                SirketAdi = "Rada",
                VergiNo = "11523123",
            };

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
