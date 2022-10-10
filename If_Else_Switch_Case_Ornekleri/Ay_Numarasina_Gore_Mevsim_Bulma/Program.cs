using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ay_Numarasina_Gore_Mevsim_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Önce IF-ELSE sonra Switch-Case kullanarak, kullanıcıdan alınan ay numarasına göre mevsimi gösteren program

            yenidenAyNumarasi2:
            Console.WriteLine("Lütfen bir ay numarası giriniz: (1/2/3/4/5/6/7/8/9/10/11/12)");
            string ayNumarasi2;
            ayNumarasi2 = Console.ReadLine();
            switch (ayNumarasi2)
            {
                case "1":
                case "2":
                case "12":
                    Console.WriteLine("Girdiğiniz ay Kış mevsimine aittir.");
                    break;

                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Girdiğiniz ay Kış mevsimine aittir.");
                    break;

                case "6":
                case "7":
                case "8":
                    Console.WriteLine("Girdiğiniz ay Kış mevsimine aittir.");
                    break;

                case "9":
                case "10":
                case "11":
                    Console.WriteLine("Girdiğiniz ay Kış mevsimine aittir.");
                    break;

                default:
                    Console.WriteLine("Yanlış bir sayı girişi yaptınız! Lütfen tekrar deneyiniz. (1/2/3/4/5/6/7/8/9/10/11/12)");
                    goto yenidenAyNumarasi2;
            }

            Console.Read();

            #endregion
        }
    }
}
