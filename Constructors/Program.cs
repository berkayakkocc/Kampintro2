using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,MusteriAd="Berkay",MusteriSoyad="Akkoç",Sehir="Ardahan" };
            Customer customer2 = new Customer(2,"Altay","Akkoç " ,"izmir");

            
            

        }
        static void Method(int id,string MusteriAd,string MusteriSoyad,string sehir)
        {

        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştır");
        }
        public int Id { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Sehir { get; set; }

    }
}
