using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    /*
         
    */
    public class HttpManager
    {
        public string Send(string url,string data)
        {
            Console.WriteLine($"{url} adresine mesaj gönderilicek");
            if ( string.IsNullOrEmpty(url) || !url.StartsWith("https:\\"))
            {
                throw new InvalidUrlException(url);
            }

            return "Http OK";
        }
    }
    // InvalidUrlException sınıfının bir Exception olarak throw edilebilmesi için
    // exception sınıfından türetilmesi(inherit) yeterlidir.
    public class  InvalidUrlException 
        : Exception
    {
        public InvalidUrlException(string url) 
            :base($"{url} bilgisi geçersiz") // base keyword, bir üst ınıfı işaret eder.
        {
            
        }
    }
}
