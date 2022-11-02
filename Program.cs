using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            main call_func = new main();
            call_func.AddCard("Proje 1", "x hakkında", "ali güneş", "XS", 1);
            call_func.AddCard("Proje 2", "y hakkında", "elif polat", "S", 2);
            call_func.AddCard("Proje 3", "z hakkında", "ibrahim tatlıses", "M", 3);
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        call_func.ListCard();
                        break;
                    case 2:
                        Console.Write("Başlık Giriniz                                  :");
                        string title = Console.ReadLine();
                        Console.Write("İçerik Giriniz                                  :");
                        string info = Console.ReadLine();
                        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                        var _size = (Size_)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Kişi Seçiniz                                    :");
                        string personal = Console.ReadLine();
                        call_func.AddCard(title, info, _size.ToString(), personal, 1);
                        break;
                    case 3:
                        call_func.RemoveCard();
                        break;
                    case 4:
                        call_func.MoveCard();
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;

                }
            }






        }














    }
}
