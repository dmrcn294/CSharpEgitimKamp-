using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimGun2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler
            //double number;
            //number = 3.45;
            //Console.WriteLine(number);
            //Console.WriteLine("********** Fiyat Listesi **********");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //double  appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.45;
            //strawGram = 4.38;
            //potatoGram = 3.52;
            //tomatoGram = 5.55;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, tomatoTotalPrice, potatoTotalPrice;

            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //potatoTotalPrice = potatoPrice * tomatoGram;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("- Elma Birim fiyatı : " + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine("- Portakal Birim fiyatı : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);
            //Console.WriteLine("- Çilek Birim fiyatı : " + strawberryPrice + " - Gramaj : " + strawGram + " - Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine("- Domates Birim fiyatı : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);
            //Console.WriteLine("- Patates Birim fiyatı : " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);

            //double toplamAlısveris;
            //toplamAlısveris = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alış Veriş Tutarı : " + toplamAlısveris + " Tl");



            #endregion
            #region CharDegiskenler
            ////ABCDEF
            ////CDAFE
            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //string passengerName, passengerSurname, passengerGender, passengerAge, passengerDistrict, passengerCity, passengerIdentiyNo;

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine();
            //Console.Write("Yolcu Kimlik No: ");
            //passengerIdentiyNo = Console.ReadLine();

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Cinsiyeti: ");
            //passengerGender = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Kimlik No: " + passengerIdentiyNo + "- Yolcu Bilgileri : " + passengerName + " " + passengerSurname + " " + passengerGender + " " + passengerAge + " " + passengerDistrict + "/" + passengerCity);



            #endregion
            #region Klavyeden Veri Girişi İnt ve Dönüşüm

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen almış olduğunu Ayakkabı adedini Giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almış olduğunu Bilgisayar adedini Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almış olduğunu Sandalye adedini Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almış olduğunu Televizyon adedini Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int toplamTutar;
            //toplamTutar=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam AlışVeriş Tutarı :  " + toplamTutar);


            #endregion
            #region Klavyeden Ondalıklı Sayı Girme

            //double exam1, exam2, exam3;

            //Console.Write("Birinci Sınav Notunu Giriniz : ");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav Notunu Giriniz : ");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav Notunu Giriniz : ");
            //exam3 =double.Parse(Console.ReadLine());

            //double ortalama;
            //ortalama = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Ders Ortalamanız : "+ortalama);


            #endregion
            #region Klavyeden Karakter Girişi
            //char gender;
            //Console.Write("Lütfen Cinsyet Giriniz E/K: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet " + gender);



            #endregion
            Console.Read();



        }
    }
}
 