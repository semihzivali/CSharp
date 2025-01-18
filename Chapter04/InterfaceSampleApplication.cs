
namespace Chapter04
{
    public abstract class GameObject
    {
        public Guid Id { get; private set; }        // read only property.
        public Vector2D Position { get; private set; }

        protected GameObject(Vector2D position)
        {
            Id = Guid.NewGuid();
            Position = position;
        }
    }

    // Abstract türlerden farklı olarak interface tipi sadece davranış tanımlar(Contract), yani iş yapan kod blokları içermezler.
    // bu interface i uygulayan her tür mutlaka bu iki metpdu yazmak zorundadır.. Dependency inversion içinde bağımlılıkarı tersine çevirmek için kullanılır.
    interface IPlayable
    {
        void Draw();  // public, protected vb(access modifiers) taşıyaamaz çünkü dopal olarak herkese açıktır.
        void Update();
    }

    public class Player 
        : GameObject, IPlayable
    {
        public string PlayerName { get; set; }
        public Player(Vector2D position)
            :base(position)
        {
        }

        public void Draw()
        {
            Console.WriteLine($"{Id} wall - is drawing.");
        }

        public void Update()
        {
            Console.WriteLine($"{Id} wall - is updating.");
        }
    }

    public class Tower
        :GameObject, IPlayable
    {
        public int Health { get; set; }
        public Tower(Vector2D position)
            : base(position)
        {
        }

        public void Draw()
        {
            Console.WriteLine($"{Id} tower - is drawing.");
        }

        public void Update()
        {
            Console.WriteLine($"{Id} tower - is updating.");
        }
    }

    public class Wall
        : IPlayable
    {
        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine($"wall - is drawing.");
        }

        public void Update()
        {
            Console.WriteLine($"wall - is updating.");
        }
    }

    public class Engine
    {
        private readonly List<IPlayable> playables = [];

        public void LoadLevel(string level)
        {
            playables.Add(new Tower ( new Vector2D { X = 100, Y = 100 }) { Health=100});
            playables.Add(new Player(new Vector2D { X = 100, Y = 100 }) { PlayerName = "player1" });
            playables.Add(new Wall { Color = "red" });
            playables.Add(new Wall { Color = "blue" });

        }

        public void Run()
        {
            // abstract sınıdlarda olduğu gibi interface tipleride new operaorü ile örneklenemez.
            foreach (IPlayable playable in playables)
            {
                playable.Update();
                playable.Draw();
            }
        }

    }

    public static class InterfaceSampleApplication
    {
        public static void Run()
        {
            var gameEngine = new Engine();
            gameEngine.LoadLevel("Beginner");
        }

    }
}
