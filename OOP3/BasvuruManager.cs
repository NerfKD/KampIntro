using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var logItem in loggerService)
            {
                logItem.Log();
            }
        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler, List<ILoggerService> loggerService)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
                foreach (ILoggerService loglar in loggerService)
                {
                    loglar.Log();
                }
            }
        }
    }
}
