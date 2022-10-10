using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ay_Numarasi_Ile_Mevsim_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Önce IF-ELSE sonra Switch-Case kullanarak, kullanıcıdan alınan ay numarasına göre mevsimi gösteren program

            Console.WriteLine("Lütfen bir ay numarası giriniz: (1/2/3/4/5/6/7/8/9/10/11/12)");
            yenidenAyNumarası:
            string ayNumarasi = Console.ReadLine();
            if (ayNumarasi == "1" || ayNumarasi == "2" || ayNumarasi == "12")
            {
                Console.WriteLine("Girdiğiniz ay Kış mevsimine aittir.");
            }
            else if (ayNumarasi == "3" || ayNumarasi == "4" || ayNumarasi == "5")
            {
                Console.WriteLine("Girdiğiniz ay İlkbahar mevsimine aittir.");
            }
            else if (ayNumarasi == "6" || ayNumarasi == "7" || ayNumarasi == "8")
            {
                Console.WriteLine("Girdiğiniz ay Yaz mevsimine aittir.");
            }
            else if (ayNumarasi == "9" || ayNumarasi == "10" || ayNumarasi == "11")
            {
                Console.WriteLine("Girdiğiniz ay Sonbahar mevsimine aittir.");
            }
            else
            {
                Console.WriteLine("Yanlış bir sayı girişi yaptınız! Lütfen tekrar deneyiniz. (1/2/3/4/5/6/7/8/9/10/11/12)");
                goto yenidenAyNumarası;
            }

            Console.Read();

            #endregion
        }
    }
}
