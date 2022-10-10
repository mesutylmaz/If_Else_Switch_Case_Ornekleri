using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilo_Ortalamasina_Gore_Cinsiyet_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //SORU 3:
            // Bir kampüsteki öğrencilerin kilo ortalamalarını, cinsiyetlerine göre bulduran program. (Algoritma örnekleri SORU 7)
            double ks = 0;
            double kkt = 0;
            double kko = 0;
            double es = 0;
            double ekt = 0;
            double eko = 0;

            KiloBilgisi:
            Console.WriteLine("Lütfen kilonuzu giriniz: ");
            double kilo;
            kilo = Convert.ToDouble(Environment.NewLine + Console.ReadLine());

            CinsiyetSecimi:
            Console.WriteLine(Environment.NewLine + "Lütfen cinsiyetinizi belirtiniz: (Erkek/Kadın)");
            string cinsiyet = (Console.ReadLine());

            if (cinsiyet == "Kadın" || cinsiyet == "kadın")
            {

                ks = ks + 1;
                Console.WriteLine(Environment.NewLine + "Kadınların sayısı: " + Convert.ToDouble(ks));

                kkt = kkt + kilo;
                Console.WriteLine(Environment.NewLine + "Kadınların kilolarının toplamı: " + Convert.ToDouble(kkt));


                kko = (kkt / ks);
                Console.WriteLine(Environment.NewLine + "Kadınların kilolarının toplamının ortalaması: " + Convert.ToDouble(kko));

            }
            else if (cinsiyet == "Erkek" || cinsiyet == "erkek")
            {
                es = es + 1;
                Console.WriteLine(Environment.NewLine + "Erkeklerin sayısı: " + Convert.ToDouble(es));

                ekt = ekt + kilo;
                Console.WriteLine(Environment.NewLine + "Erkeklerin kilolarının toplamı: " + Convert.ToDouble(ekt));


                eko = (ekt / es);
                Console.WriteLine(Environment.NewLine + "Erkeklerin kilolarının toplamının ortalaması: " + Convert.ToDouble(eko));

            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Hatalı giriş yaptınız! Lütfen cinsiyet seçimini tekrar yapınız.");
                goto CinsiyetSecimi;
            }
            BaskaÖgrenci:
            Console.WriteLine(Environment.NewLine + "Başka öğrenci var mı? (Evet/Hayır)");
            string cevapVer = Console.ReadLine();
            if (cevapVer == "Evet" || cevapVer == "evet")
            {
                goto KiloBilgisi;
            }
            else if (cevapVer == "Hayır" || cevapVer == "hayır")
            {
                Console.WriteLine(Environment.NewLine + "Girilen bilgilere göre son durum aşağıdaki gibidir.");
                Console.WriteLine(Environment.NewLine + "Erkeklerin sayısı: " + Convert.ToDouble(es));
                Console.WriteLine(Environment.NewLine + "Erkeklerin kilolarının toplamı: " + Convert.ToDouble(ekt));
                Console.WriteLine(Environment.NewLine + "Erkeklerin kilolarının toplamının ortalaması: " + Convert.ToDouble(eko));
                Console.WriteLine(Environment.NewLine + "Kadınların sayısı: " + Convert.ToDouble(ks));
                Console.WriteLine(Environment.NewLine + "Kadınların kilolarının toplamı: " + Convert.ToDouble(kkt));
                Console.WriteLine(Environment.NewLine + "Kadınların kilolarının toplamının ortalaması: " + Convert.ToDouble(kko));
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Hatalı giriş yaptınız! Lütfen tekrar giriş yapınız.");
                goto BaskaÖgrenci;
            }

            Console.Read();

            #endregion
        }
    }
}
