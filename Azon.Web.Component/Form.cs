
namespace Azon.Web.Component
{
    public class Form
    {
        private readonly List<Control> _controls = [];

        private readonly IPersistence _persistence;
        public Form(IPersistence persistence) // constructor injection.
        {
            _persistence = persistence;
        }
        public void AddControls(params Control[] controls)
        {
            _controls.AddRange(controls);
        }
        public void LocateAll()
        {
            foreach (Control control in _controls)
            {
                Console.WriteLine($"{control.Id} location set.");
            }
        }
        public void DrawAll()
        {
            foreach (Control control in _controls)
            {
                if (control is IDrawable drawable)    // tüm controllerde idrawable impemente etmedik o yüzden sadece olanlarda Draw kullanabiliyoruz.
                {
                    drawable.Draw();
                }
            }
        }

        public void Save()
        {
            _persistence.Save(_controls);
        }
        /*
        public void Save()
        {

            var builder = new StringBuilder();
            foreach (Control control in _controls)
            {
                builder.AppendLine(control.ToString());

            }
            var content = builder.ToString();
            File.WriteAllText("Form.dat", content);
        }
        */
    }

}
