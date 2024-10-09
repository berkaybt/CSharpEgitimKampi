using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Giriş ");
            //}


            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalıdır");
            //}


            //int exam1, exam2, exam3, average;

            //string result ="Hatalı Sonuç"; //mutlaka bir değer girilmelidir.

            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavları Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";

            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);//// burda hata olmaması için string = "Hatalı Sonuç" kodundan bağsediyorum

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if(city=="adana" | city=="ankara"| city == "bursa" | city =="trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değildir.");
            //}

            //Console.Write("Lütfen kullanıı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}








            #endregion ELSE




            #region  Mod İşlemleri 


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);



            //Console.Write("Lütfen 1 Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2 Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: "+result);




            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0) 
            //{
            //    Console.Write("Sayı Çifttir");

            //}
            //else
            //{
            //    Console.Write("Sayı Tektir.");
            //}













            #endregion


            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembol Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{

            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{

            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{

            //    Console.Write("Beşiktaş");
            //}


            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();




            //string menu;
            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi:  ");
            //menu = Console.ReadLine();
            //if (menu == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Ana Yemekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- Ana Yemekler-------------");
            //    Console.WriteLine();


            //}

            //if (menu == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Çorbalar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- Çorbalar -------------");
            //    Console.WriteLine();


            //}
            //if (menu == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Pizzalar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- Pizzalar -------------");
            //    Console.WriteLine();


            //}
            //if (menu == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İçecekler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- İçecekler -------------");
            //    Console.WriteLine();


            //}
            //if (menu == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Tatlılar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------- Tatlılar -------------");
            //    Console.WriteLine();


            //}







            #endregion



            #region Swicth Case 


            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;


            //}




            #endregion


            #region Swicth Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}










            #endregion






            Console.ReadKey();
        }
    }
}
