//Beni Yaratan Elbet Yolumu Gösterir .Şuara 78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price;
            price = 9.99;
            double ex1;
            double ex2;
            double ex3;
            double avg;
            ex1 = 88.50;
            ex2 = 50;
            ex3 = 65.30;
            avg = (ex1 + ex2 + ex3) / 3;

            Console.WriteLine("Cost of product :"+" "+price);
            Console.WriteLine();
            Console.WriteLine("Average of exams :"+" "+avg);
            Console.Read();
        }
    }
}
