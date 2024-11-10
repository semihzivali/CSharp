namespace Chapter03
{
    /*
     Bütün exception türleri Exception kelimesi ile biter.(ismlendirme standardı) 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try  // try bloğunda olablicek hatalar(exeption) catch blklarınca yakalanabilir ve program akışı kontrollü hale gelebilir.
            {
                //double result = Div(10, 0); // Eğer burda 0'a bölme hatası kontrol edilmezse burada program crash olur.
                // Eğer bir exeption oluşursa, try bloğu içerisindeki diğer kodlara bakmaz. direk catch bloğuna girer.
                //var f = File.OpenRead("C:\\unknown_file.data");

                //throw new ArgumentException("Argumen hatasi");

                //var silo = new HttpManager();
                //var result = silo.Send("http.\\movie.sdfjks", "");
                //Console.WriteLine(result);

                Plane vecihi = new Plane { X = 10, Y = 20 };
                vecihi.Draw();
                vecihi.Fire();

                Player mario = new Player { X=11, Y=12 };
                mario.Draw();
                mario.Jump();

                GameObject go1 = vecihi;  // Bu mümkündür. vecihi bir Plane nesnesidir, ve plane nesneside bir GameObject nesnesidir.
                go1.Draw();  // polymorphism. go1 Plane gibidir 
                GameObject go2 = mario;
                go2.Draw();
            }
            catch (DivideByZeroException eX)  // 0'a bölme hatası olursa bu blok çalışacak
            {
                Console.WriteLine(eX.Message);
            }
            catch (FileNotFoundException eX)
            {
                Console.WriteLine($"{eX.Message}");
            }
            catch (InvalidUrlException ex)
            {
                Console.Write(ex.Message);
            }
            catch (Exception eX)  // try bloğunda ele alınmamış bir exeption varsa bu blok çalışır.
            {
                // Exeption diğer tüm exeption neslerini çevreler.
                Console.WriteLine(eX.Message); 
            }
            finally
            {
                Console.WriteLine("try bloğunda hata olsa da olmasa da çalışır.");

            }
            Console.WriteLine("Program end");
 
        }

     //   static int Div(int a, int b)
       // {
         //   return a / b;
       // }
        
        static Response Div(int x, int y)
        {
            if( y== 0)
            {
                return new Response
                {
                    value = 0,
                    IsSucess = false,
                    ErrorMessage = "Sıfıra bölme hatası"
                };
            }
            return new Response
            {
                value = x / y,
                IsSucess = true,
                ErrorMessage = string.Empty
            };
        }

        static Response SaveInvoice(double amount, int customerId)
        {
            return new Response
            {
                IsSucess = false,
                value = amount,
                ErrorMessage = "limit yetersiz"
            };
        }

        static void DrawLevel(string level, List<GameObject> gameObjects)
        {
            foreach(var go in gameObjects)
            {
                go.Draw();
            }
        }
    }
}

class Response
{
    public object value { get; set; }
    public bool IsSucess { get; set; }
    public string ErrorMessage { get; set; }

}

