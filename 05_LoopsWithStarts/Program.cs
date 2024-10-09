using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta 10 tane yıldız oluştırma


            //for(int i =1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}









            #endregion



            #region  Yanyana 10 tane yıldız oluştırma


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion


            #region Alt alta 10 tane yıldız oluştırma her satırda 10 tane yıldız olsun


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion




            #region Dik Üçgen


            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for(int i = 10;i >=0 ;i--)
            //{
            //    for (int j = 1;j <= i;j++)
            //        { Console.Write("*"); }
            //    Console.WriteLine();
            //}






            #endregion



            #region Ters Dik Üçgen

            //for (int i = 10; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    { Console.Write("*"); }
            //    Console.WriteLine();
            //}





            #endregion





            #region Dik ve Test dik üçgen beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion



            #region Baklava Dilimi

            //int n = 5;
            //for(int i=1; i<= n; i++)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i= n - 1; i >= 1; i--)
            //{
            //    for(int j=n-1; j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion



            #region Piramit


            //int n = 5;
            //for(int  i = 1;i <= n; i++)
            //{
            //    //Boşluklar
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");

            //    }
            //    //Yıldızlar
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}









            #endregion



            Console.ReadKey();
        }
    }
}
