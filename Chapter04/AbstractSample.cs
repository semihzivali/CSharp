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
        public Guid Id { get; private set; }
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
            Console.WriteLine("Invader draw operation.");
        }
        public override void Draw()
        {
            Console.WriteLine("Invader draw operation.");
        }
    }

    public class World
    {
        public string Title{ get; set; }
        private readonly List<GameEntity> entities = [];

        public void LoadLevel(string LevelName)
        {
            var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            var greenPlane = new Vehicle(new Vector2D { X = 200, Y = 303 });
            entities.Add(blueCar);
        }

    public static class PublicSampleApplication
    {
        public static void Run()
        {
            var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            var greenPlane = new Vehicle(new Vector2D { X = 20, Y = 30 });
            var invaders = new Invader[10];
            for (int i = 0; i < 10; i++)
            {
                invaders[i] = new Invader(new Vector2D { X = i * 2, Y = 0 });
            }
        }
    }
}   
