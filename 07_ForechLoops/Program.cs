using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForechLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Forach Döngüsü

            // Foraech(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi






            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}







            //int[] numbers = { 45,78,985,635,74,11,22,33,41,205,6578,10394 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}






            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };



            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}







            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);





            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}





            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}













            #endregion



            #region Örnek Sınav Sistemi Uygulaması 


            Console.Write("***** C# Eğitimi Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();
                double totalExamResult = 0;

                // Her öğrenci öğrenci için 3 sınav notu girişi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} adlı öğrencinin {j + i}. sınav notunu giriniz:  ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz.


                }
                studentExamAvg[i] = totalExamResult / 3;

            }
            
            //sınav ortalamaları
            for(int i = 0;i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması:  {studentExamAvg[i]}");

                // Öğrencilerin ortalaması ve geçip kalma durumuları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-------------------------------");
            }
















            #endregion










            Console.ReadKey();
        }
    }
}
