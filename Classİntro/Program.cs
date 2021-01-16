using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Berkay";
            int yas = 24;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = 88;


            //Console.WriteLine(kurs2.IzlenmeOrani + " : " + kurs2.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " +kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public  string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
