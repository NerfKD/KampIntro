using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir nesnede bir değeri kullanmak zorunda değilsen oraya ait değilse orada soyutlama hatası yapılıyor demektir.
    //Individual - Bireysel
    // ":" Miras - Inheritance
    class GercekMusteri : Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
