using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar___
{
    class sepetmanager
    {
        public void Add(Product Product)
        {
            Console.WriteLine("Sepete Ekledin");
        }
        public void AddAlternative(string Name ,String Explanation, double Price)
        {
            Console.WriteLine("Sepete Eklendi" + Name);
        }
    }
}
