using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int para = 1000;
            Console.WriteLine("1- Bakiye görüntüleme 2- Para çekme 3- Para yatırma 4- Çıkış");
            while (true)
            {
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Bakiyeniz: "+para);
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Kaç para çekiceksin");
                    int cekim = Convert.ToInt32(Console.ReadLine());
                    para -= cekim;
                    Console.WriteLine(cekim + " TL çekildi" + " Yeni Bakiyeniz: " + para);
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Kaç para yatıracaksın");
                    int yatirma = Convert.ToInt32(Console.ReadLine());
                    para += yatirma;
                    Console.WriteLine(yatirma + " TL yatırıldı" + " Yeni bakiyeniz: " + para);
                }
                else if (secim == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli seçim yapınız");
                }
            }
        }
    }
}
