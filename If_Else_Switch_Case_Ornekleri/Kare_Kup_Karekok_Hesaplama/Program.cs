using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kare_Kup_Karekok_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //SORU 4:
            // Kullanıcıdan alınan bir sayının (double) karesini, küpünü ve karekökünü hesaplayan program...
            // İşlem char tipinde girilecek.
            // Karesi: 1, Küpü: 2, Karekökü: 3 olarak girilecek ve sayısal değer girilmediyse uyarı mesajı vererek tekrar girmesi istenecek.

            SayiGir:
            Console.WriteLine("Sayı giriniz: ");
            double sayi;
            sayi = Convert.ToDouble(Console.ReadLine());
            //bool sayiDurum = double.TryParse(Console.ReadLine(), out sayi);           //Girdiğin ifade double mı diye sorguluyor, yani double sayı girersek sayiDurum'u true kabul edicek. Double girmezsek sayiDurum'u false düşünecek.

            //if(!sayiDurum)
            //{
            //    Console.WriteLine("Lütfen girdiğiniz sayıyı değiştirin!");
            //    goto SayiGir;
            //}
            İslemSec:
            Console.WriteLine("İşlem seçiniz: (Sayının karesi için 1/Sayının küpü için 2/Sayının karekökü için 3)");
            char islemSec;
            islemSec = Convert.ToChar(Console.ReadLine());


            if (islemSec == '1')
            {
                Console.WriteLine("Girilen sayının karesi: " + Convert.ToDouble(sayi * sayi));
            }
            else if (islemSec == '2')
            {
                Console.WriteLine("Girilen sayının küpü: " + Math.Pow(sayi, 3));
            }
            else if (islemSec == '3')
            {
                Console.WriteLine("Girilen sayının karekökü: " + Math.Sqrt(sayi));
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen yeni işlem seçimi yapınız.");
                goto İslemSec;
            }
            yeniSayi:
            Console.WriteLine("Yeni sayı girmek ister misiniz? (Evet/Hayır)");
            string cevapSec;
            cevapSec = Convert.ToString(Console.ReadLine());

            if (cevapSec == "Evet" || cevapSec == "evet")
            {
                goto SayiGir;
            }
            else if (cevapSec == "Hayır" || cevapSec == "hayır")
            {
                Console.WriteLine("İşleminiz sona ermiştir.");
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız! Lütfen tekrar deneyiniz.");
                goto yeniSayi;
            }

            Console.Read();

            #endregion
        }
    }
}
