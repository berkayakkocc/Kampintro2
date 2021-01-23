using System;

namespace ConstructorKendim
{
    class Program
    {
        
            static void Main(string[] args)
            {
            
            Console.WriteLine("Bir sayi giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seçiminizi yapın (Toplama:1");
            }
        class DortIslem
        {
            public double topla(double sayi1,double sayi2)
            {
                return (sayi1 + sayi2);

            }
            public double cikar(double sayi1, double sayi2)
            {
                return (sayi1 - sayi2);
            }
            public double carp (double sayi1,double sayi2)
            {
                return (sayi1 * sayi2);
            }
            public double bol(double sayi1, double sayi2)
            {
                return (sayi1 / sayi2);
            }
        }
        
        
        
    }
       
        
}
