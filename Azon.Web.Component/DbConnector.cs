
namespace Azon.Web.Component
{
    public class DbConnector
        : Control
    {
        public DbConnector(int id, string name, (double, double) position) 
            : base(id, name, position)
        {
        }

        public string ConnectionString { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}|{ConnectionString}";
        }
    }
}
