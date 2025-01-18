
namespace Chapter05.Components
{
    public abstract class ButtonBase
        : Control
    {
        public string BacgroundColor { get; set; }
        public string ForegroundColor { get; set; }
        protected ButtonBase(int id, string name, (double, double) position) 
            : base(id, name, position)
        {
        }
    }
}
