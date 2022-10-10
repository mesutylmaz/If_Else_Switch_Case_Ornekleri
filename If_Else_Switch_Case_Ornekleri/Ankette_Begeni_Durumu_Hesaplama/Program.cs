using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankette_Begeni_Durumu_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //SORU 5:
            // Bir ürün için yapılan ankette beğenen, beğenmeyen, kararsız kalanların sayısını ve toplam müşteri sayısını ekrana yazdıran program.
            // (Switch-Case ile) - (Algoritma örnekleri SORU 6)
            int bs = 0;
            int bms = 0;
            int kararsızlar = 0;
            Secim:
            Console.WriteLine("Ürünle ilgili fikriniz nedir? (Beğendim/Beğenmedim/Kararsızım");
            string cevapAl;
            cevapAl = Console.ReadLine();

            switch (cevapAl)
            {
                case "Beğendim":
                case "beğendim":
                    bs = bs + 1;
                    Console.WriteLine("Beğenenlerin sayısı: " + Convert.ToInt32(bs));
                    break;

                case "Beğenmedim":
                case "beğenmedim":
                    bms = bms + 1;
                    Console.WriteLine("Beğenmeyenlerin sayısı: " + Convert.ToInt32(bms));
                    break;

                case "Kararsızım":
                case "kararsızım":
                    kararsızlar = kararsızlar + 1;
                    Console.WriteLine("Kararsızların sayısı: " + Convert.ToInt32(kararsızlar));
                    break;

                default:
                    Console.WriteLine("Lütfen belirtilen cevaplardan birini seçiniz.");
                    goto Secim;

            }
            Console.WriteLine("Başka müşteri var mı? (Evet/Hayır)");
            YanitSec:
            string yanit;
            yanit = Console.ReadLine();

            switch (yanit)
            {
                case "Evet":
                case "evet":
                    goto Secim;

                case "Hayır":
                case "hayır":
                    Console.WriteLine("Anket tamamlanmıştır.");
                    Console.WriteLine("Hizmeti beğenenlerin sayısı: " + Convert.ToInt32(bs));
                    Console.WriteLine("Hizmeti beğenmeyenlerin sayısı: " + Convert.ToInt32(bms));
                    Console.WriteLine("Hizmetin kalitesinden kararsız olanların sayısı: " + Convert.ToInt32(kararsızlar));
                    Console.WriteLine("Tüm müşteri sayısı: " + Convert.ToInt32(bs + bms + kararsızlar));
                    break;

                default:
                    Console.WriteLine("Lütfen belirtilen yanıtlardan birini seçiniz.");
                    goto YanitSec;
            }

            Console.Read();

            #endregion
        }
    }
}
