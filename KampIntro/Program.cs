using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategoriler";
            int kategoriSayisi = 32000;
            double kategoriOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.34;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butou ");

            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Başarıyla Giriş Yapılmıştır");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriSayisi);
        }
    }
}
