using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //deger tipleri-- int float 
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi1:" + sayi1);

            //referans tipler... array,class
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "berkay";//Person 1 in adını berkay olarak ata
            person2 = person1;//person1 deki deger ile person2 degeri aynı olsun
            person1.FirstName = "altay";//daha sonra person1 in adını altay diye değiştir
            Console.WriteLine(person2.FirstName);//person 2 nin first nameini ekrana yazdır 
            //Ekranda altay çıkacak çünkü kodlar ustten alta doğru çalışır ve daha öncesinde iki değişkenin degerlerini aynı atadıgımız
            //için ne değişiklik yaparsak onu ekranda yansıtacak

            Customer customer = new Customer();
            customer.FirstName = "uğur";
            customer.CreditCardNumber = "1111111";


            Employee employee = new Employee();
            Person person3 = customer;
            customer.FirstName = "Mert";

            Console.WriteLine(((Customer)person3).CreditCardNumber);
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }
    }
}
