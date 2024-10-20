using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimGun3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //string password;
            //Console.Write("Lütfen Parolayı Giriniz : ");
            //password = Console.ReadLine();

            //if (password == "abcde")
            //{
            //    Console.WriteLine("Parola Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Şifre");
            //}
            //string city, country;
            //Console.Write("Lütfen Şehir Bilgisini Giriniz : ");
            //city = Console.ReadLine();
            //Console.Write("Lüfen Ülke Bilgisi Giriniz : ");
            //country = Console.ReadLine();

            //if (city=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Eşleştirmeler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Eşleşme ");
            //}
            //int exam1, exam2, avarage;
            //string result;
            //Console.Write("Sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2 : ");
            //exam2=int.Parse(Console.ReadLine());
            //avarage = (exam1 + exam2) / 2;
            //if (avarage >0 & avarage<50)
            //{
            //    Console.WriteLine("Ortalama " + avarage + " Başarısız");
            //}
            //else if (avarage>=50 & avarage<75)
            //{
            //    Console.WriteLine("Ortalama " + avarage + " Zayıf");
            //}
            //else if(avarage>=75 & avarage<85)
            //{
            //    Console.WriteLine("Ortalama " + avarage + " İyi");
            //}
            //else if(avarage>=85 & avarage<=100)
            //{
            //    Console.WriteLine("Ortalama " + avarage + " Pekiyi");
            //}
            //else
            //{
            //    Console.WriteLine("Ortalama Tanımsız");
            //}



            #endregion

            #region Mod İşlemleri
            //int number;
            //Console.Write("Lütfen Bir Sayı Giriniz : ");
            //number=int.Parse(Console.ReadLine());

            //if (number > 0) 
            //{
            //    if(number%2==0)
            //    {
            //        Console.WriteLine("Girilen Sayı Pozitif ve Çift Sayıdır. ");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Girilen Sayı Pozitif ve Tek Sayıdır");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Negatiftir");
            //}

            #endregion

            #region Char Değişkeni ile karar Yapıları
            //char teams;
            //Console.Write("Lütfen Takımınızın Baş Harfini Tuşlayın : ");
            //teams = char.Parse(Console.ReadLine());

            //if(teams == 'g' || teams == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(teams=='f' || teams =='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if(teams=='b' || teams =='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Tanımlı Değil");
            //}




            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("********** CSharp Lokantası **********");
            //Console.WriteLine();
            //int choise;
            //Console.WriteLine("--- 1 Ana Yemekler");
            //Console.WriteLine("--- 2 Çorbalar");
            //Console.WriteLine("--- 3 Salatalar");
            //Console.WriteLine("--- 4 Tatlılar");
            //Console.WriteLine("--- 5 İçecekler");
            //Console.WriteLine();
            //Console.Write("Görmek İstediğiniz Menüyü Seçin : ");
            //choise=int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine();
            //if(choise==1)
            //{
            //    Console.WriteLine("--- 1 İmam Bayıldı");
            //    Console.WriteLine("--- 2 Kavurma");
            //    Console.WriteLine("--- 3 Tavuk Sote");
            //    Console.WriteLine("--- 4 Kuru Fasulye");
            //    Console.WriteLine("--- 5 Et Sote");

            //}
            //else if(choise==2)
            //{
            //    Console.WriteLine("--- 1 Mercimek");
            //    Console.WriteLine("--- 2 Ezogelin");
            //    Console.WriteLine("--- 3 Domates");
            //    Console.WriteLine("--- 4 Yayla");
            //    Console.WriteLine("--- 5 İşkembe");
            //}
            //else if (choise == 3)
            //{
            //    Console.WriteLine("--- 1 Çoban");
            //    Console.WriteLine("--- 2 Mevsim");
            //    Console.WriteLine("--- 3 Söğüş");
            //    Console.WriteLine("--- 4 Gavurdağ");
            //    Console.WriteLine("--- 5 Rus");
            //}
            //else if(choise==4)
            //{
            //    Console.WriteLine("--- 1 Sütlaç");
            //    Console.WriteLine("--- 2 Kemal Paşa");
            //    Console.WriteLine("--- 3 Kadayıf");
            //    Console.WriteLine("--- 4 Kazan Dibi");
            //    Console.WriteLine("--- 5 Vezir Parmağı");
            //}
            //else if (choise==5)
            //{
            //    Console.WriteLine("--- 1 Cola");
            //    Console.WriteLine("--- 2 IceTea");
            //    Console.WriteLine("--- 3 Soda");
            //    Console.WriteLine("--- 4 Su");
            //    Console.WriteLine("--- 5 Çay");
            //}
            //else
            //{
            //    Console.WriteLine("Seçilen Menü Bulunamadı!");
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");



            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ayı Sayı ile Belirtiniz : ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Girilen Ay Bulunamadı"); break;
            //}






            #endregion

            #region Hesap Makinası
            //int number1, number2, result;
            //Console.Write("Birinci Sayı : ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("İkinci Sayı : ");
            //number2=int.Parse(Console.ReadLine());
            //char islem;
            //Console.Write("Yapmak istenilen işlem  : ");
            //islem=char.Parse(Console.ReadLine());
            //Console.WriteLine();
            //switch(islem)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç : "+result);break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç : " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç : " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç : " + result); break;
            //    default: Console.WriteLine("Girilen İşlem Mevcut Değil!!!"); break;
            //}



            #endregion




            Console.Read();

        }
    }
}
