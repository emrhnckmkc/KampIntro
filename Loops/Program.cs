using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım";
            string kurs2 = "Programlama";
            string kurs3 = "Java";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //dizi - array
            string[] kurslar = new string[] { "Yazılım", "Programlama", "Java", "Phyton", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            //kursları dolaşjj

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}