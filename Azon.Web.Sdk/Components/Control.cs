namespace Azon.Web.Sdk.Components
{
    public abstract class Control
    {
        public int Id { get; set; }
        protected string? Name { get; set; }
        protected (double, double) Position { get; set; }    // bu tip tuple dır.

        protected Control(int id, string name, (double, double) position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Id}|{GetType().Name}|{Name}|{Position}|";
        }
    }
}
