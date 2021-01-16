using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kerim";
            int yas = 29;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Kerim Dinçer";
            kurs1.IzlenmeOrani = 10;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre Dinçer";
            kurs2.IzlenmeOrani = 15;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Melih Esmer";
            kurs3.IzlenmeOrani = 13;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
