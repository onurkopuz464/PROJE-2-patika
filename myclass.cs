using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class process
    {
        public string Title { get; set; }
        public string info { get; set; }
        public string personel { get; set; }
        public string size { get; set; }

    }

    public enum Size_
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
    public enum lineCard
    {
        TODO =1,INPROGRESS,DONE
    }
    public class main
    {
        List<process> TodoLine = new List<process>();
        List<process> IN_PROGRESS_Line = new List<process>();
        List<process> DONE_Line = new List<process>();

        public void AddCard(string a, string b, string c, string d, int line)
        {
            switch (line)
            {
                case 1:
                    TodoLine.Add(new process { Title = a, info = b, personel = c, size = d });
                    break;
                case 2:
                    IN_PROGRESS_Line.Add(new process { Title = a, info = b, personel = c, size = d });
                    break;
                case 3:
                    DONE_Line.Add(new process { Title = a, info = b, personel = c, size = d });
                    break;
            }

        }

        public void ListCard()
        {
            foreach (var item in TodoLine)
            {
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
                Console.WriteLine("Başlık      :" + item.Title);
                Console.WriteLine("İçerik      :" + item.info);
                Console.WriteLine("Atanan Kişi :" + item.personel);
                Console.WriteLine("Büyüklük    :" + item.size);
                Console.WriteLine("-");


            }
            foreach (var item in IN_PROGRESS_Line)
            {
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
                Console.WriteLine("Başlık      :" + item.Title);
                Console.WriteLine("İçerik      :" + item.info);
                Console.WriteLine("Atanan Kişi :" + item.personel);
                Console.WriteLine("Büyüklük    :" + item.size);
                Console.WriteLine("-");


            }
            foreach (var item in DONE_Line)
            {
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
                Console.WriteLine("Başlık      :" + item.Title);
                Console.WriteLine("İçerik      :" + item.info);
                Console.WriteLine("Atanan Kişi :" + item.personel);
                Console.WriteLine("Büyüklük    :" + item.size);
                Console.WriteLine("-");


            }



        }

        public void RemoveCard()
        {
            bool contiuneAnswer = true;
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            while (contiuneAnswer == true)
            {
                Console.Write("Lütfen kart başlığını yazınız:  ");
                string title = Console.ReadLine();
                process findTitle = TodoLine.Find(x => x.Title.Contains(title));


                if (findTitle == null)
                {
                    int answer = 0;
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            contiuneAnswer = false;
                            break;
                        case 2:
                            break;
                    }

                }
                else
                {
                    TodoLine.Remove(findTitle);
                    Console.WriteLine("Başarı ile Silindi.");
                    contiuneAnswer = false;

                }
            }

        }

        public void MoveCard()
        {
            bool contiuneAnswer = true;
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            while (contiuneAnswer == true)
            {
                Console.Write("Lütfen taşımak istediğiniz kart başlığını yazınız:  ");
                string title = Console.ReadLine();
                process findTitle = TodoLine.Find(x => x.Title.Contains(title));


                if (findTitle == null)
                {
                    int answer = 0;
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            contiuneAnswer = false;
                            break;
                        case 2:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      :" + findTitle.Title);
                    Console.WriteLine("İçerik      :" + findTitle.info);
                    Console.WriteLine("Atanan Kişi :" + findTitle.personel);
                    Console.WriteLine("Büyüklük    :" + findTitle.size);
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                    var _value = (lineCard)Convert.ToInt32(Console.ReadLine());
                    switch (_value)
                    {
                        case lineCard.TODO:
                            TodoLine.Add(findTitle);
                            break;
                        case lineCard.INPROGRESS:
                            IN_PROGRESS_Line.Add(findTitle);
                            break;
                        case lineCard.DONE:
                            DONE_Line.Add(findTitle);
                            break;
                        default:
                            break;
                    }
                    
                    TodoLine.Remove(findTitle);
                    contiuneAnswer = false;







                }
            }
        }

    }

}
