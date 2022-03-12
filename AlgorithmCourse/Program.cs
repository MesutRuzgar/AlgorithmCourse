using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            //Example1();

            Console.WriteLine("Sayıyı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());

            if (sayi1<0)
            {
                Console.WriteLine("Sayınız negatiftir.");
            }
            else if (sayi1>0)
            {
                Console.WriteLine("Sayınız pozitiftir.");

            }
            else
            {
                Console.WriteLine("Sayınız nötrdür.");
            }

            Console.ReadLine();
        }

        private static void Example1()
        {
            Console.WriteLine("Birici sayıyı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("Büyük sayı: {0}", sayi1);
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("Büyük sayı: {0}", sayi2);
            }
            else
            {
                Console.WriteLine("Sayılar eşit.");
            }
        }

        private static void Intro()
        {
            Console.WriteLine("İsim giriniz.");
            string isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldin {0}", isim);
        }
    }
}
