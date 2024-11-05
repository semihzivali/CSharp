using System;

namespace Chapter02.UI.View
{
    /*
        Terminal aslında kullanıcı ile etkileşimde olunan bir ortam. Genel olarak View olarak ifade edilir.
        Bu uygulamanın UI(User Interface) ile ilgili işlerinin toplandığı, View alanı altında konuşlandırılmıştır.
        
        Burada en zoru hangi türü hangi isim alanı(namespace) altına alacağımıza karar vermektir. Bu anlamda genel yazılım
        prensipleri ve pratikleri var. Örneğin MVC (Model View Controller) veya MVVM (Model View View Model)

        Terminal sınıfının fonksiyonları sadece Console ile çalışır halde. Genel olarak Terminal ile Console sınıfı arasında sıkı bağlı
        bir ilişki olduğunu söyleyebiliriz (Thightly Coupled) OOP tarafında mümkün mertebe nesneler arası bağımlılıkları azaltmaya çalışırız.
        Buda Losely Coupled olarak geçer. Yani amaç Terminal sınıfının sadece Console ile çalışması değil örneğin bir IoT terminali ile de 
        çalışması olabilir.

        Arada gelen soru üzerine sonrası için bakmamız gereken ilkeler;
        SOLID 
            Single Responsibility
            Open Closed
            Liskov Substituation
            Interface Segregation
            Dependency Inversion

        Terminal sınıfının tüm üyeleri static olarak tanımlandığından kendisinin de static olması önerilir.
    */
    internal static class Terminal   // Bir sınıfın tüm metodları static ise kendisinin de static olması önerilir.
    {
        /*
            SplashScreen herhangibir parametre almayan ve değer döndürmeyen (void) bir metottur.
            Main metodu static tanımlanmış bir metot olduğundan, Program sınıfı içindeki SplashScreen metodunun
            çağırlabilmesi için onun da static tanımlanması gerekir.

            Bir metodu, parametre yapısını farklılaştırarak çoğaltabilir ve aynı isimle kullanabiliriz(Overloading)
            Overloading işleminde kural parametre sayısı ve türleri ile alakalıdır(Method Signature)

            Eğer aksini belirtmezsek, sınıf üyeleri private erişim belirleyicisine sahiptir (Access Modifiers)
            private, public, internal, protected ve protected internal şeklinde 5 temel erişim belirleyicisi vardır.

            internal erişim belirleyici sadece tanımlı olduğu proje için kullanımı serbest bırakır.
            public ise her yerden erişilebilir anlamındadır.

            Aynı/benzer amaca hizmet eden tipleri (class, struct, enum, interface, delegate) aynı namespace çatısında toplamak
            veya aynı/benzer amaca hizmet eden üyeleri/members (field, property, method, event, constructor...) aynı tip altında 
            toplamak, domain anlamında bütünsellik sağlamak için önemlidir.
            Örneğin, terminal ekranı ile ilgili yapılacak işleri Terminal isimli bir sınıf altında topladığımız gibi.
         */
        internal static void SplashScreen()
        {
            Console.WriteLine("**************");
            Console.WriteLine("**Welcome Stranger***");
            Console.WriteLine("***************");
        }
        internal static void SplashScreen(string playerName)
        {
            Console.Write(GetText('+', 24));
            Console.WriteLine("Welcome {0}", playerName);
            Console.WriteLine(new string('*', 24));
            Console.ReadLine();
        }
        internal static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Start (S)");
            Console.WriteLine("Point Table (PT)");
            Console.WriteLine("Settings (SET)");
            Console.WriteLine(GetText('_', 24));
            Console.WriteLine("Exit (E) \n");
            Console.WriteLine("Please Choose One");
        }

        internal static void GetUserInput()
        {
            var input = Console.ReadLine();  // geriye string döndürüyor.
            var userInput = input.ToLower();
            if (userInput == "S")
            {
                Console.WriteLine("Game starting.");
            }
            else if (userInput == "PT")
            {
                Console.WriteLine("Point table");
            }
            else if (userInput == "SET")
            {
                Console.WriteLine("Settings");
            }
            else if (userInput == "E")
            {
                Console.WriteLine("Game ending");
            }
            else
            {
                Console.WriteLine("Please select correct option");
            }
        } 
        static string GetText(char c, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += c;
            }
            result += "\n";
            return result;
        }
    }
}
