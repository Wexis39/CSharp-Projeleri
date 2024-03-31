using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-toplama , 2-cikarma , 3-carpma , 4-bolme , 5-faktoriyel , 6-cikis");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Toplama islemi");
                    Console.WriteLine("1. sayiyi giriniz");
                    int toplamaSayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. sayiyi giriniz");
                    int toplamaSayi2 = Convert.ToInt32(Console.ReadLine());
                    int toplamaSonuc = (toplamaSayi1 + toplamaSayi2);
                    Console.WriteLine("Toplama sonucu = " + toplamaSonuc);
                }
                if (secim == "2")
                {
                    Console.WriteLine("Cikarma islemi");
                    Console.WriteLine("1. sayiyi giriniz");
                    int cikarmaSayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. sayiyi giriniz");
                    int cikarmaSayi2 = Convert.ToInt32(Console.ReadLine());
                    int cikarmaSonuc = (cikarmaSayi1 - cikarmaSayi2);
                    Console.WriteLine("Cikarma sonucu = " + cikarmaSonuc);
                }
                if (secim == "3")
                {
                    Console.WriteLine("Carpma islemi");
                    Console.WriteLine("1. sayiyi giriniz");
                    int carpmaSayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. sayiyi giriniz");
                    int carpmaSayi2 = Convert.ToInt32(Console.ReadLine());
                    int carpmaSonuc = (carpmaSayi1 * carpmaSayi2);
                    Console.WriteLine("Carpma sonucu = " + carpmaSonuc);

                }
                if (secim == "4")
                {
                    Console.WriteLine("Bolme islemi");
                    Console.WriteLine("1. sayiyi giriniz");
                    int bolmeSayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. sayiyi giriniz");
                    int bolmeSayi2 = Convert.ToInt32(Console.ReadLine());
                    int bolmeSonuc = (bolmeSayi1 / bolmeSayi2);
                    Console.WriteLine("Carpma sonucu = " + bolmeSonuc);
                }
                if (secim == "5")
                {
                    Console.WriteLine("Faktoriyel islemi");
                    Console.WriteLine("Faktoriyeli hesaplanacak sayiyi giriniz");
                    int faktoriyelSayi = Convert.ToInt32(Console.ReadLine());
                    int FaktoriyelSonuc = 1;
                    for (int i = faktoriyelSayi; i > 1; i--)
                    {
                        FaktoriyelSonuc *= i;
                    }
                    Console.WriteLine(FaktoriyelSonuc);
                }
                if (secim == "6")
                {
                    break;
                }
            }
        }
    }
}
