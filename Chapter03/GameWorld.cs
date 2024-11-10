namespace Chapter03
{
    // C# multi-inheritance desteklemez.
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual void Draw()  // default bir davranışı vardır. ama istersek değiştirebiliriz
        {
            Console.WriteLine("Nesne çizdirme operasyonu.");
        }
    }

    public class Plane
        :GameObject
    {
        public int Altitude { get; set; }
        public int Health { get; set; }
        public void Fire()
        {
            Console.WriteLine("Uçak ateş ediyor");
        }
        public override void Draw()
        {
            Console.WriteLine("Uçak çiziliyor");
        }
    }
    
    public class Player
        :GameObject
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public void SayGreeting()
        {
            Console.WriteLine("Player greetings");
        }
        public void Jump()
        {
            Console.WriteLine("player jumping");
        }
    }
}
