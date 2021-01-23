using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir nesnede bir değeri kullanmak zorunda değilsen oraya ait değilse orada soyutlama hatası yapılıyor demektir.
    //Coorporate - Tüzel
    // ":" Miras - Inheritance
    class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
