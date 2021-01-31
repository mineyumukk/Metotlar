using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        //Parametre alan metot
        public void Ekle(Product product)
        {
            Console.WriteLine("TEBRİKLER. Sepete Eklendi : " + product.Adi);
        }

       public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)
       {
            Console.WriteLine("TEBRİKLER. Sepete Eklendi : " + productAdi);
       }
    }
}
