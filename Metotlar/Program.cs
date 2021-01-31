using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class referansı tanımlamak 
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";


            Product[] products = new Product[] {product1, product2 };

            // in products, products dizisinin her bir elemanını gez demek
            // product o an ki yani döngünün takma ismi 
            // Product ise veri tipi

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("----------Metotlar------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Armut", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

            Console.ReadLine();
        }
    }
}

