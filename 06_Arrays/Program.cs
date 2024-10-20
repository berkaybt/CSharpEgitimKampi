using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri


            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";


            //Console.WriteLine(colors[2]);

            //string[] cites = new string[5];

            //cites[0] = "Milano";
            //cites[1] = "Budapeşte";
            //cites[2] = "Lyon";
            //cites[3] = "Kahire";
            //cites[4] = "üsküp";

            //Console.WriteLine(cites[5]);



            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;

            //Console.WriteLine(numbers);


            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[2]);





            #endregion


            #region Dizideki Tüm Elemanları Listeleme


            //string[] colors = { "Sarı", "Kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}




            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}






            //char[] symbols = { 'a', 'b', 'c','*','/','-' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}






            #endregion


            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşe", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+ numbers.Max()+ " Dizinin En Küçük Elemanı: "+numbers.Min());





            #endregion



            #region Kullanıcında Değer Alma



            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehir Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}





            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);





            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift sayılar");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek Sayılar");

            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
           








            #endregion



            Console.ReadKey();
        }
    }
}
