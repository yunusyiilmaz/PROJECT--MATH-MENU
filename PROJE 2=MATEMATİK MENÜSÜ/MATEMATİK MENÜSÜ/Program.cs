﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATEMATİK_MENÜSÜ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title="MATEMATİK MENÜSÜ";
            Console.Write("********************************************\n");
            Console.Write("MATEMATEİKSEL İŞLEMLER MENÜSÜNE HOŞ GELDİNİZ\n");
            Console.Write("********************************************\n");
            Console.WriteLine("1- ARİTMETİK 4 İŞLEM \n");
            Console.WriteLine("2- ÜS ALMA\n");
            Console.WriteLine("3- KÖK ALMA\n");
            Console.WriteLine("4- KARENİN ÇEVRE VE ALANINI HESAPLAMA\n");
            Console.WriteLine("5- DİKDÖRTGENDE ALAN VE ÇEVRE HESAPLAMA\n");
            Console.Write("6- EŞKENAR ÜÇGENDE ÇEVRE HESAPLAMA\n");
            Console.Write("********************************************\n");
            Console.Write("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ :");
            string islem=Console.ReadLine();

            Console.Clear();

            if (islem == "1")
            {
                Console.Write("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ :");
                string a = Console.ReadLine();
                int sonuc = 0;
                Console.Write("SAYI GİRİNİZ :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("SAYI GİRİNİZ :");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                if (a == "+")
                {
                    sonuc = sayi + sayi1;
                    Console.WriteLine("SONUÇ :" + sonuc);
                    Console.ReadLine();
                }
                else if (a == "-")
                {
                    sonuc = sayi - sayi1;
                    Console.WriteLine("SONUÇ :" + sonuc);
                    Console.ReadLine();
                }
                else if (a == "*")
                {
                    sonuc = sayi * sayi1;
                    Console.WriteLine("SONUÇ :" + sonuc);
                    Console.ReadLine();
                }
                else if (a == "/")
                {
                    sonuc = sayi / sayi1;
                    Console.WriteLine("SONUÇ :" + sonuc);
                    Console.ReadLine();
                }

            }
                if(islem=="2")
                {
                    Console.Write("SAYI GİRİNİZ :");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("ALINCAK ÜSSÜ GİRİNİZ :");               
                int üs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                    Console.WriteLine("SAYININ ÜSSÜ :"+Math.Pow(b,üs));
                    Console.ReadLine();
                }
                Console.Clear();
            if(islem=="3")
            {
                Console.Write("SAYI GİRİNİZ :");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("SAYININ KAREKÖKÜ :" + Math.Sqrt(c));
                Console.ReadLine();

            }
            if (islem == "4")
            {
                Console.Write("KENAR UZUNLUĞU GİRİNİZ :");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("KARE'NİN ALANI :" + Math.Pow(c,2));
                Console.WriteLine("KARENİN ÇEVRESİ :"+c*4);
                Console.WriteLine();
                Console.ReadLine();

            }
            if (islem == "5")
            {
                Console.Write("KISA KENAR UZUNLUĞU GİRİNİZ :");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("UZUN KENAR UZUNLUĞU GİRİNİZ :");
                int d1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("DİKDÖRTGE'NİN ALANI :" + d*d1);
                Console.WriteLine();
                Console.WriteLine("KARENİN ÇEVRESİ :" + 2*(d + d1));
                Console.WriteLine();
                Console.ReadLine();

            }
            if (islem == "6")
            {
                Console.Write("KISA KENAR UZUNLUĞU GİRİNİZ :");
                int e = Convert.ToInt32(Console.ReadLine());
                
                
                Console.WriteLine();
                Console.WriteLine("KARENİN ÇEVRESİ :" + 3 * e);
                Console.WriteLine();
                Console.ReadLine();

            }
            Console.WriteLine("GEÇERSİZ SEÇİM YAPTINIZ.");


            Console.ReadKey();
            
        }
    }
}
