﻿using System;
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
            int vize, final;
            Console.WriteLine("Vize notunuzu giriniz.");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());

            if (vize>=30 && final>=30)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }





            Console.ReadLine();
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
