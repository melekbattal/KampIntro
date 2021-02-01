using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "Kurs1";
            kurs1.KursEgitmeni = "Eğitmen";
            kurs1.IzlenmeOrani = 78;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Kurs2";
            kurs2.KursEgitmeni = "Eğitmen";


            kurs kurs3 = new kurs();
            kurs2.KursAdi = "Kurs2";
            kurs2.IzlenmeOrani = 65;
            kurs2.KursEgitmeni = "Eğitmen 2";

            kurs kurs4 = new kurs();
            kurs3.KursEgitmeni = "Eğitmen 3";
            kurs3.IzlenmeOrani = 32;

            kurs kurs5 = new kurs();
            kurs5.KursEgitmeni = "Melek";

            Console.WriteLine(kurs1.KursAdi + "  :  " + kurs1.KursEgitmeni);
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursEgitmeni);
            }
        }
    }
}



class kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}
