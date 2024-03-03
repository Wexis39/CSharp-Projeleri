using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Metehan";
            string sifre = "123";
            int hak =   3;
            while (true)
            {
                if (hak > 0)
                {
                    Console.WriteLine("Kullanıcı adınız:");
                    string _ad = Console.ReadLine();
                    Console.WriteLine("Şifreniz:");
                    string _sifre = Console.ReadLine();
                    if (ad == _ad && sifre == _sifre)
                    {
                        Console.WriteLine("Giriş Başarılı !");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Giriş Yaptınız...");
                        hak--;
                        Console.WriteLine("kalan deneme hakkın: " + hak);
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Hakkın bitti!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
