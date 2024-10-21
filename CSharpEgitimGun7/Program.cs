using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimGun7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //foreach(1;2;3;4)
            //1 Değişken türü
            //2 Değiken adı
            //3 içinde anlamı taşıya İN
            //4 liste dizi koleksiyon


            //string[] cities = { "milano", "istanbul", "beyrut", "şam", "kahire", "moskova" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = { 2, 5, 8, 24, 55, 124, 8976, 10235, 354, 47, 692 };
            //foreach(int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = { 2, 5, 8, 24, 55, 124, 8976, 10235, 354, 47, 692 };
            //foreach(int x in numbers)
            //{
            //    if(x%2==0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}
            //int[] numbers = { 2, 5, 8, 24, 55, 124, 8976, 10235, 354, 47, 692 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            //--------------------------------------------
            //List<int> numbers = new List<int>()
            //{
            //    1,2,5,7,9,11,13,15
            //};
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //---------------------------------------------
            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Genel Tekrar Niteliğinde
            Console.Write("Öğrenci Sayısını Giriniz : ");
            int ogrsay = int.Parse(Console.ReadLine());
            string[] ogrenci = new string[ogrsay];
            int[] sınavlar = new int[3];
            for(int i=0;i<ogrenci.Length;i++)
            {
                Console.Write("Öğrenci Adı Giriniz : ");
                ogrenci[i] = Console.ReadLine();
            }
           
            for (int j=0;j<ogrenci.Length;j++)
            {
                
                int ortalama=0;
                
                for(int s=0;s<sınavlar.Length;s++)
                {
                    Console.WriteLine();
                    Console.Write($"{s+1}. Sınavı Girin : ");
                    sınavlar[s] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Öğrenci {ogrenci[j]} nin Notları");
                foreach(int i in sınavlar)
                {
                    Console.WriteLine(i);
                }
                
                foreach(int i in sınavlar)
                {
                    ortalama += i;
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Öğrenci {ogrenci[j]} nin Ortalaması : "+ortalama/3);
                Console.WriteLine();
                Console.WriteLine();
                if(ortalama<50)
                {
                    Console.WriteLine($"Öğrenci {ogrenci[j]} Sınıfta Kaldı");
                }
                else
                {
                    Console.WriteLine($"Öğrenci {ogrenci[j]} Sınıfta Kaldı");
                }
            }

            #endregion

            Console.Read();
        }
    }
}
