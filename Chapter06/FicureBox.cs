using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;

namespace Chapter06
{
    public class FicureBox
        : Control, IDrawable
    {
        public string ImagePath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public FicureBox(int id, string name, (double, double) position) : base(id, name, position)
        {
        }
        public void Draw()
        {
            Console.WriteLine("PictureBox draw");
        }
    }
}
