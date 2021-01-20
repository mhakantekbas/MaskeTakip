using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Hakan");
            SelamVer("Ali");
            SelamVer("Özcan");
            SelamVer();
            int sonuç = Topla(8,9);

            //<Diziler /Arrays 
            string ogrenci1 = "Engin";
            string ogrenci2 = "Berkay";
            string ogrenci3 = "Kerem";

            string[] ogreciler = new string[3];
            ogreciler[0] = "Engin";
            ogreciler[1] = "Berkay";
            ogreciler[2] = "Kerem";
            

            for (int i = 0; i< ogreciler.Length; i++)
            {
                Console.WriteLine(ogreciler[i]);
            }
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "Kayseri" };
            string[] sehirler2 = new[] { "Mersin", "Hatay", "Balıkesir" };
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Muhammed Hakan";
            person1.LastName = "Tekbaş";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 27892792264;
            
            Person person2 = new Person();
            person2.FirstName = "Engin";


            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1" , "İstanbul 2 " , "Kayseri 3 "};
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

                Console.ReadLine();

        }
            static void SelamVer(string isim="isimsiz")
          
        {
              Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayı1, int sayı2)
        {
            int sonuç = sayı1 + sayı2;
            Console.WriteLine("Toplam "+ sonuç);
            return sonuç;
        }
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 1000000;
            int sayi = 100;
            bool girisYapmısMı = false;

            string ad = "Hakan";
            string soyaf = "Tekbaş";
            int dogumyılı = 2000;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public  string Soyad { get; set; }
        public string Dogumyili { get; set; }
        public string TcNo { get; set; }



    }

}
