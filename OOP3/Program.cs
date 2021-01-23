using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu şekilde de newlenebilir.
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();                          // direkt new olarakda yazılabilir.
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new FileLoggerService(), new SmsLoggerService() });
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediManagers = new List<IKrediManager>() { new IhtiyacKrediManager(), new TasitKrediManager(), new KonutKrediManager() };
            List<ILoggerService> logServices = new List<ILoggerService>() { new FileLoggerService(), new SmsLoggerService(), new DatabaseLoggerService() };
            basvuruManager.KrediOnBilgilendirmeYap(krediManagers, logServices);




        }
    }
}
