using System.Globalization;

namespace Chapter04
{
    public struct Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
    /* Abstract members diğer iş yapan üyeler gibi kod blokları içermezler.
       Abstrack üyeler, abstract sınıf içerisinde olabilirler.
     */ 

    public abstract class GameEntity
    {
        public Guid Id { get; private set; }        // read only property.
        public Vector2D Position { get; private set; }

        protected GameEntity(Vector2D position)
        {
            Id = Guid.NewGuid();
            Position = position; 
        }
        public abstract void Draw();    // Dikkat!! Method body yok.
        public abstract void Update();

    }

    public class Vehicle
        : GameEntity
    {
        public Vehicle(Vector2D position)
            : base(position)
        {
        }
        public override void Update()
        {
            Console.WriteLine($"{base.Id} - Vehicle update operation.");
        }
        public override void Draw()
        {
            Console.WriteLine("Vehicle draw operation.");
        }
    }

    public class Invader
        :GameEntity
    {
        public Invader(Vector2D position)
            : base(position) 
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{base.Id} - Invader update operation.");
        }

        public override void Draw()
        {
            Console.WriteLine("Invader draw operation.");
        }

    }

    public class World
    {
        public string Title { get; set; }
        private readonly List<GameEntity> entities = [];

        public void LoadLevel(string LevelName)
        {
            Console.WriteLine($"{LevelName} is loading ...");
            var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            var greenPlane = new Vehicle(new Vector2D { X = 200, Y = 303 });
            entities.AddRange([blueCar, greenPlane]);

            var invaders = new Invader[10];
            for (int i = 0; i < 10; i++)
            {
                invaders[i] = new Invader(new Vector2D { X = i * 2, Y = 0 });
            }
            entities.AddRange(invaders);
        }

        public void DrawAll()
        {
            foreach (var entity in entities)
            {
                entity.Draw();
            }
        }

        public void UpdateAll()
        {
            foreach(var entity in entities)
            {
                entity.Update();
            }
        }
    }

    public static class AbstractSampleApplication  // static sınıflar tanımladıları nesneiin örneğine ihtiyaç yokrut. no need to new()
    {
        public static void Run()
        {
            var gameWorld = new World { Title = "Space invaders begginer."};
            gameWorld.LoadLevel("Beginner");
            for (; ; )   // sonsuz döngü. Oyunlar genelde böyle çalışır.
            {
                Thread.Sleep(5000); // 5 saniye duraklat.
                gameWorld.UpdateAll();
                gameWorld.DrawAll();
            }
            
            /*
            var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            var greenPlane = new Vehicle(new Vector2D { X = 20, Y = 30 });
            var invaders = new Invader[10];
            for (int i = 0; i < 10; i++)
            {
                invaders[i] = new Invader(new Vector2D { X = i * 2, Y = 0 });
            }
            */
        }
    }
}   
