using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, double, bool = değer tip
            //array,class,interface = referans tip
            //stack(değer tipler tutulur) ve heap(referans tipler içerikleri tutulur, aliasları gene stackde tutulur) olarak bellekde iki yerimiz mevcut.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1); //30 olur cevap
            //sadece stackte tutulduğu için adres mantığı olmadığı için problem olmaz.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999 olur cevap
            //diziler eşitlendiğinde stack de bulunan dizi alias ının sadece heap de ki adresi değiştiri. sayilar1 = sayilar2 olduğunda sayilar1 dizisi sayilar2 nin heap de ki adresini alır.
            //Bu sebeple sayilar2[0] değiştiğinde sayilar1[0] ekrana yazdırılmak istense adresleri ortak olduğu için 999 gelecektir.
        }
    }
}
