using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Mylist <string> isimler = new Mylist<string>();
            isimler.Add("Berkay");

            Console.WriteLine(isimler);

            Console.WriteLine("Hello World!");
        }
    }
}
