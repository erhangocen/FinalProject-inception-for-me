using System;

namespace Business.CCS
{
    public class DatabaseLoger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Loglandı");
        }
    }
}