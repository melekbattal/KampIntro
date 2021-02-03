using System;

namespace Metodlar___
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Name = "Bilgisayar";
            Product1.Price = 7.650;
            Product1.Explanation = "Casper";

            Product Product2 = new Product();
            Product2.Name = "Fare";
            Product2.Price = 120;
            Product2.Explanation = "Oyun faresi";

            Product[] products = new Product[] {Product1, Product2,};


            //type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("---------------------methodlar");
            sepetmanager sepetmanager = new sepetmanager();
            sepetmanager.Add(Product1);
            sepetmanager.Add(Product2);
            
           
             

        }
    }
}
