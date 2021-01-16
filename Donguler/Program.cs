using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Temel kurs";
            string kurs3 = "Java Kursu";

            
            

            // array = dizi 

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", " Temel kurs","Java Kursu","Phyton" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
