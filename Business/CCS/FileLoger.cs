using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class FileLoger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
