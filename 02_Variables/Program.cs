using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("******** Fiyat Listesi ***********");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice);
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram,orangeGram,strawberryGram, potatoGram, tomatoGram;
            //appleGram =1.245;
            //orangeGram =2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice= tomatoGram * tomatoGram;


            //Console.WriteLine("Alınan Ürün : Elme - "+"Birim Fiyat: "+applePrice+" - Gramaj:  " + appleGram +" - Toplam Fiyatı: "+appleTotalPrice);
            //Console.WriteLine() ;
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + potatoPrice+ " - Gramaj:  " + orangeGram+ " - Portakal Toplam Fiyatı: " + orangeTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj:  " + strawberryGram + " - Çilek Toplam Fiyatı: " + strawberryTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat: " + potatoPrice+ " - Gramaj:  " + potatoGram+ " - Patates Toplam Fiyatı: " + potatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat: " + tomatoPrice+ " - Gramaj:  " + tomatoGram+ " - Domates Toplam Fiyatı: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alişveriş Toplam Tutar: " + shoppingTotalPrice + " TL");


            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri string değişkenler

            //Console.WriteLine("**** CSharp Hava Yollar Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerIdentityNumber+ "  Yolcu: " + passengerName +" "+ passengerSurname+" "+passengerDistrict+" / "+passengerCity+" "+passengerAge);




            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;


            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Televizyon sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalPrice);




            #endregion



            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1 , exam2 ,exam3, result ;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız "+result);

            #endregion



            #region Klavyeden Karakter Girişler


            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiniz Cinsiyet : " + gender);




            #endregion





            Console.ReadKey();
        }
    }
}
