using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            for (karakter = 'a'; karakter <= 'z'; karakter++)
            {
                Console.Write("{0} ", karakter);
            }
            Console.ReadKey();




            int toplam, sayi, i;
            toplam = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}. sayıyı yazınız ", i);
                sayi = Convert.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.Write("Yazdığınız sayıların toplamı = {0}", toplam);
            Console.ReadKey();






            int toplam = 0;
            Console.WriteLine("Sayıyı girin:);
            int sayi = Convert.Parse(Console.ReadLine());
            for (int i = 0; i <= sayi; i++)
            {
                toplam += i;
                toplam = toplam + i;
            }
            Console.WriteLine("1-{0} arası sayıların toplamı = {1}", sayi, toplam);
            Console.ReadKey();
            */




            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("KAAN EROGLU");
            }
            Console.ReadKey();






            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();






            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                { Console.WriteLine(i); }
            }
            Console.ReadKey();





            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                { Console.WriteLine(i); }
            }
            Console.ReadKey();





            int sayac = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}. sayıyı gir :", i);
                int sayi = Int32.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    sayac++;
                }
            }

            Console.WriteLine("{0} adet çift sayı var", sayac);
            Console.ReadKey();








            For Döngüsü kullanılarak Kullanıcıdan 10 adet isim alarak başına numaraların da ekleyerek ekranda yazdıran örnek:

                      string isim;
            Console.Write("İSminiz nedir?");
            isim = Console.ReadLine();
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} : {1}", i, isim);
            }
            Console.ReadKey();






            string isim;
            Console.Write("İSminiz nedir?");
            isim = Console.ReadLine();
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} : {1}", i, isim);
            }
            Console.ReadKey();
        }
    }
}
