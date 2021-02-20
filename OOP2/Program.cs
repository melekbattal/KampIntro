using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Melek";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Sinan Yazilim";

            Musteri musteri3 = new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();

            //Musteri gerçek ve tuzelin referansını da tutabilir.


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri4);
        }
    }
}
