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
            //Example2();
            //Example3();
            //SwitchCaseExample();
            //Example4();
            //Example5();
            //Example6();
            //Example7();

            //pozitif tam bölenler
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }               
            }

            //iki sayı arasındaki tek sayıları bulan kod
            int sayi1, sayi2;
            Console.WriteLine("iki adet sayı giriniz.");
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        private static void Example7()
        {
            Console.WriteLine("Etiket fiyatını giriniz.");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double indirim = 0.18;
            double yeniFiyat = fiyat - (fiyat * indirim);
            Console.WriteLine("Etkiket fiyatı: {0}", fiyat);
            Console.WriteLine("İndirim oranı:{0}", indirim);
            Console.WriteLine("İndirimli fiyatı:{0}", yeniFiyat);

            int sayi, yuzler, onlar, birler;
            Console.WriteLine("Bir sayı giriniz.");
            sayi = int.Parse(Console.ReadLine());
            yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi;


            Console.WriteLine("Sayınızın yüzler basamağı:{0}", yuzler);
            Console.WriteLine("Sayınızın onlar basamağı:{0}", onlar);
            Console.WriteLine("Sayınızın birler basamağı:{0}", birler);
        }

        private static void Example6()
        {
            int vize, final;
            Console.WriteLine("Vize notunuzu giriniz.");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());

            if (vize >= 30 && final >= 30)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
        }

        private static void Example5()
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int kalan = sayi % 2;

            if (kalan != 0)
            {
                Console.WriteLine("Tek");
            }
            else
            {
                Console.WriteLine("Çift");
            }
        }

        private static void Example4()
        {
            Console.WriteLine("Üçgenin 1. açısını giriniz.");
            int aci1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin 2. açısını giriniz.");
            int aci2 = int.Parse(Console.ReadLine());

            int aci3 = 180 - (aci1 + aci2);
            Console.WriteLine("Üçgenin 3. açısı: {0}", aci3);
        }

        private static void SwitchCaseExample()
        {
            Console.WriteLine("Haftanın kaçıncı günü?");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Hatalı giriş!");

                    break;
            }
        }

        private static void Example3()
        {
            baslangic:
            Console.WriteLine("Haftanın kaçıncı günü?");
            int gun = Convert.ToInt32(Console.ReadLine());

            if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Pazar");
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
                goto baslangic;
            }
        }

        private static void Example2()
        {
            Console.WriteLine("Sayıyı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());

            if (sayi1 < 0)
            {
                Console.WriteLine("Sayınız negatiftir.");
            }
            else if (sayi1 > 0)
            {
                Console.WriteLine("Sayınız pozitiftir.");

            }
            else
            {
                Console.WriteLine("Sayınız nötrdür.");
            }
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
