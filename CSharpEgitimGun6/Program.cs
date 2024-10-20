using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimGun6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // 2.4.6.8.10
            //istanbul,ankara,düzce,bursa,konya
            //mavi, siyah, kırmızı, mor, kahverengi
            //string[] colors = new string[5];
            //colors[0] = "mavi";
            //colors[1] = "Mor";
            //colors[2] = "Siyah";
            //colors[3] = "Beyaz";
            //colors[4] = "kahverengi";
            //Console.WriteLine(colors[3]);
            //string[] cities = { "Ankara", "Roma", "Milano", "Prag", "Kahire", "Beyrut" };
            //Console.WriteLine(cities[4]);
            //int[] ciftler = new int[10];
            //ciftler[0] = 50;
            //ciftler[1] = 48;
            //ciftler[2] = 698;
            //ciftler[3] = 120;
            //ciftler[4] = 314;
            //ciftler[7] = 66;

            //Console.WriteLine(ciftler[3]);
            //Console.WriteLine(ciftler[6]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Kırmızı", "Siyah", "Mavi", "Beyaz", "Mor", "Pembe", "Kahverengi" };
            //for(int i =0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i =0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //char[] karakter = { 'a', 'b', 'c', 'd' };
            //for(int i=0;i<karakter.Length;i++)
            //{
            //    Console.WriteLine(karakter[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0;i< myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i =0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Girinz :");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //for(int i =0;i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //int[] numbers = new int[5];
            //int toplam = 0;

            //for (int i = 0; i < numbers.Length;i++)
            //{
            //    Console.Write("Sayı Giriniz : ");
            //    numbers[i] =int.Parse(Console.ReadLine());
            //}
            //for(int j=0;j<numbers.Length;j++)
            //{
            //    toplam = toplam + numbers[j];
            //}
            //Console.WriteLine(toplam);
            int[] sayilar = { 1, 3, 5, 6, 8, 9, 11, 14, 17, 22, 28, 31 };
            Console.WriteLine("Çİft Sayılar");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < sayilar.Length;i++)
            {
                if (sayilar[i]%2==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }







            #endregion



            Console.Read();
        }
    }
}
