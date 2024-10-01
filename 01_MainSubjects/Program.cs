using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");
            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region Değişkenler

            // String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);
            //Console.WriteLine("------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "sapanca";
            //city = "Sakarya";
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);
            //Console.WriteLine("------------------------------------");








            #endregion



            #region Int Değişkenler


            // int
            // int number = 24;
            // Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadaPrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger:  " + hamburgerPrice + " TL");
            Console.WriteLine("----- Coke:  " + cokePrice + " TL");
            Console.WriteLine("----- Water:  " + waterPrice + " TL");
            Console.WriteLine("----- Fries:  " + friesPrice + " TL");
            Console.WriteLine("----- Pizza:  " + pizzaPrice + " TL");
            Console.WriteLine("----- Lemonada:  " + lemonadaPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadaCount;
            int lemonadoCount;

            int totalHamgurgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadoPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadaCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadoPrice = lemonadaCount * lemonadaPrice;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Coke Tutarı: " + totalCokePrice + " TL"); 
            Console.WriteLine("Water Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Fries Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Lemonado Tutarı: " + totalLemonadoPrice + " TL");

            int toplam = 0;

            toplam = totalHamgurgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadoPrice;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Toplam: " + toplam + " TL");




            #endregion

            Console.ReadLine();
        }
    }
}







// Yazdırma komutları



