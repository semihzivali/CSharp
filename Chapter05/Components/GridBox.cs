
using Chapter05.Contracts;
using static System.Net.Mime.MediaTypeNames;

namespace Chapter05.Components
{
    public class GridBox
        : Control, IDrawable
    {
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public GridBox(int id, string name, (double, double) position) 
            : base(id, name, position)
        {
        }

        public void Draw()
        {
            Console.WriteLine("Gridbox draw at {0}:{1}", Position.Item1, Position.Item2);
        }

        public override string ToString()
        {
            return $"{base.ToString()}|{RowCount}|{ColumnCount}";
        }
    }
}
