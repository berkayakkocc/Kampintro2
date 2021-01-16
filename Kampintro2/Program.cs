using System;

namespace Kampintro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  type safety = tip güvenliği
            // do not repeat yourself - Kendini tekrarlama!
            //değer tutucu,alias


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double DolarDun= 7.45;
            double DolarBugun = 7.15;

            if (DolarDun > DolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı  Ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(ogrenciSayisi);

            Console.WriteLine(faizOrani);


            

        }
    }
}
