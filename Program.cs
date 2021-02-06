using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MYList<string> isimler = new MYList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);



        }
    }
}
