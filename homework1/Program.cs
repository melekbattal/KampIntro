using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektrikSupurgesi Tesla = new ElektrikSupurgesi();
            Tesla.Fiyat = 1.250;
            Tesla.UrunKodu = "12004F";
            Tesla.TıklanmaSayisi = 12456;

            ElektrikSupurgesi Bora = new ElektrikSupurgesi();
            Bora.Fiyat = 1.350;
            Bora.UrunKodu = "12356KK";
            Bora.TıklanmaSayisi = 2589;

            ElektrikSupurgesi TozTorbali = new ElektrikSupurgesi();
            TozTorbali.Fiyat = 1.450;
            TozTorbali.UrunKodu = "12456KK";
            TozTorbali.TıklanmaSayisi = 522589;


            ElektrikSupurgesi TozTorbasiz = new ElektrikSupurgesi();
            TozTorbasiz.Fiyat = 1.650;
            TozTorbasiz.UrunKodu = "1235OKK";
            TozTorbasiz.TıklanmaSayisi = 122589;


            ElektrikSupurgesi[] süpürgeler = new ElektrikSupurgesi[] {Tesla, Bora, TozTorbali, TozTorbasiz };

            foreach (var ElektrikSupurgesi in süpürgeler)
            {
                Console.WriteLine(ElektrikSupurgesi.UrunKodu);
                //Console.WriteLine(Bora.Fiyat);
                //Console.WriteLine(Tesla.UrunKodu);
                //Console.WriteLine(Tesla.Fiyat);
                
            }


        }
    }
}



class ElektrikSupurgesi
{
    public double Fiyat { get; set; }
    public string UrunKodu { get; set; }
    public int TıklanmaSayisi { get; set; }
}
