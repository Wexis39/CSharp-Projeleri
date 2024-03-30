using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Cevre hesaplamak icin 1 , Alan hesaplamak icin 2 , Cikmak icin 3");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Kisa kenari giriniz");
                    int kisaKenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Uzun kenari giriniz");
                    int uzunKenar = Convert.ToInt32(Console.ReadLine());
                    int kenarUzunlugu = (kisaKenar * 2) + (uzunKenar * 2);
                    Console.WriteLine("Cevre uzunlugu = " + kenarUzunlugu);
                }
                if (secim == "2")
                {
                    Console.WriteLine("Kisa kenari giriniz");
                    int kisaKenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Uzun kenari giriniz");
                    int uzunKenar = Convert.ToInt32(Console.ReadLine());
                    int alan = (kisaKenar * uzunKenar);
                    Console.WriteLine("Alani = " + alan);
                }
                if (secim == "3")
                {
                    break;
                }
            }
        }
    }
}
