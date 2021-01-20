using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri() { Adi = "Emir", Soyadi = "Öztürk", Adres = "İstanbul", Eposta = "mr_emirozturk@outlook.com", Id = 1 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri);

            musteriManager.Ekle(musteri);

            musteriManager.Sil(musteri);

            musteriManager.Guncelle(musteri);

        }
    }
}
