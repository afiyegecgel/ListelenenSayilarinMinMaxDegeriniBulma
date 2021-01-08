using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListelenenSayılarınMinMaxDegeriniBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selam, kaç elemanlı bir liste vereyim abime :D");
            int elemanSayisi=Convert.ToInt32(Console.ReadLine());
            List<int> sayilar = new List<int>();

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı gir:");
                sayilar.Add(Convert.ToInt32(Console.ReadLine()));
            }

            /* Başlangıçta en büyük elemanın listenin ilk elemanı olduğunu ve aynı şekilde listenin 
             * en küçük elemanının listenin ilk elemanı olduğunu varsaydım. Varsayılan bu min ve max değerlerini listenin her 
             * elemanıyla tek tek karşılaştırısak ve her karşılastırma sonucunda olası değişikliği kaydedersek min ve max değerlere ulaşırız.
            */
            int min = sayilar[0];
            int max = sayilar[0];

            for (int i = 0; i < elemanSayisi; i++)
            {
                if(min>sayilar[i])
                {
                    min = sayilar[i];
                }

                if(max<sayilar[i])
                {
                    max = sayilar[i];
                }
            }

            //Toplam değer için listenin elemanlarını her iterasyonda üzerine ekleyerek topladım.
            int toplam = 0;
            for (int i = 0; i < elemanSayisi; i++)
            {
                toplam = toplam + sayilar[i];
            }

            int ortalama = toplam / elemanSayisi;

            Console.WriteLine($"En büyük sayı {max} En küçük sayı {min} Ortalama {ortalama}");
            Console.ReadLine();

        }
    }
}
