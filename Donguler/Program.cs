using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "1.Kurs";
            //string kurs2 = "2.Kurs";
            //string kurs3 = "3.Kurs";

            //Console.WriteLine(kurs1);

            string[] kurslar = new string[] {"1.Kurs" , "2. Kurs" , "3. Kurs", "4.Kurs" ,"5.Kurs"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach bitti");

            Console.WriteLine("sayfa sonu");

        }
    }
}
