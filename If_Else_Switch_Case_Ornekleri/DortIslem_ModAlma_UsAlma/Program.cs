using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem_ModAlma_UsAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Kullanıcıdan alınan 2 sayı(decimal) ve işlem tipine (byte) göre sonucu ekrana yazdıran program(Switch-Case ile)
            //Toplam:1, Fark:2, Çarpım:3, Bölüm:4, Mod Alma:5, Üs Alma:6
            //Başka işlem yapmak istiyor musunuz sorusuna Hayır(H veya h) girilene kadar işleme devam edilsin.

            BirinciTekrar:
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            İkinciTekrar:
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            islem:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: (1/2/3/4/5/6)");
            byte islem = Convert.ToByte(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine("Toplam: " + (sayi1 + sayi2));
            }
            else if (islem == 2)
            {
                Console.WriteLine("Fark: " + (sayi1 - sayi2));
            }
            else if (islem == 3)
            {
                Console.WriteLine("Çarpım: " + (sayi1 * sayi2));
            }
            else if (islem == 4)
            {
                if (sayi1 == 0)
                {
                    Console.WriteLine("Hatalı giriş yaptını! Lütfen tekrar sayı girişi yapınız. (Payda 0 olamaz.)");
                    goto İkinciTekrar;
                }
                else
                {
                    Console.WriteLine("Bölüm: " + (sayi1 / sayi2));
                }
            }
            else if (islem == 5)
            {
                if (sayi1 == 0)
                {
                    Console.WriteLine("Hatalı giriş yaptını! Lütfen tekrar sayı girişi yapınız. (Payda 0 olamaz.)");
                    goto İkinciTekrar;
                }
                else
                {
                    Console.WriteLine("Sayıların Modu: " + (sayi1 % sayi2));
                }
            }
            else if (islem == 6)
            {
                Console.WriteLine("Sayıların üsleri: " + Math.Pow(Convert.ToDouble(sayi1), Convert.ToDouble(sayi2)));
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen istenen işlemlerden birini seçiniz.");
                goto islem;
            }
            cevapSec:
            Console.WriteLine("Başka bir işlem yapmak ister misiniz? (E/H)");
            string cevap = Console.ReadLine();

            if (cevap == "E" || cevap == "e")
            {
                Console.Clear();
                goto BirinciTekrar;
            }
            else if (cevap == "H" || cevap == "h")
            {
                Console.WriteLine("İşlem tamamlanmıştır.");
            }
            else
            {
                Console.WriteLine("Lütfen istenen cevaplardan birini seçiniz.");
                goto cevapSec;
            }

            Console.Read();

            #endregion
        }
    }
}
