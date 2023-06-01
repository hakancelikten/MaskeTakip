// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Workaround
{
    class Program
    {

        static void Main(string[] argrs)
        {


            SelamVer(); //merhaba isimsiz
            SelamVer("hakan");// merhaba hakan
            SelamVer("haktan");

            int sonuc = Topla(30, 50);

            //ARRAYS-DİZİLER

            string ogrenci1 = "engin";
            string ogrenci2 = "cansu";
            string ogrenci3 = "hakan";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "cansu";
            ogrenciler[2] = "hakan";

            // string[] ogrenciler = new []{ "engin", "cansu", "hakan" }; yazabiliriz tek satırda.

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "ankara", "ist", "izmir" };
            string[] sehirler2 = new[] { "bursa", "antalya", "diyar" };
            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);

           // YENİ ŞEHİR EKLEME//

            string[] sehirler3 = new[] { "ankara", "ist", "izm" };

            int yeniUzunluk = sehirler3.Length + 1;

            string[] yeniSehirler = new string[yeniUzunluk];

            for (int i = 0; i < sehirler3.Length; i++)
            {
                yeniSehirler[i] = sehirler3[i];

                yeniSehirler[yeniUzunluk - 1] = "malatya";
            }

            //LİST KULLANMADAN YENİ ŞEHİR EKLEME//
            //string[] iller = new string[2];
            //iller[0] = "ank2";
            //iller[1] = "ist2";
            //string[] Soniller = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    iller[2] = "izmir2";
            //    Console.WriteLine(iller[i]);
            //}

            //foreach (var SonIller in iller)
            //{
            //    Console.WriteLine(iller);

            //}

            ////kendim yazıyorum list kullanmadan ülke ekleme

            //string[] ulkeler = new string[3];
            //ulkeler[0] = "turkiye";
            //ulkeler[1] = "almanya";
            //ulkeler[2] = "norvec";
            //string[] Sonulkeler = new string[3];
            //for (int i = 0; i < 4; i++) ;
            //{
            //    ulkeler[3] = "makedonya";

            //    Console.WriteLine(ulkeler[i]);
            //}

            //foreach (var SonUlkeler in ulkeler) ;
            //{
            //    Console.WriteLine(ulkeler);
            //}


           




            foreach (string sehir in sehirler3)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "ankara1", "istanbul1", "izmir1" };
            yeniSehirler1.Add("adana1");
            {
                foreach (var sehir in yeniSehirler1)
                {
                    Console.WriteLine(sehir);
                }
            }

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")//predefined parameters
        {
            Console.WriteLine("merhaba " + isim);
        }
        static int Topla(int sayi1 = 8, int sayi2 = 8)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam=" + sonuc);
            return sonuc;
        }
    }
}
    




