using Chapter05.Components;
using Chapter05.Containers;
using Chapter05.Persistence;

namespace Chapter05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvSaver = new CsvPersistence();
            //var dbSaver = new DbPersistence(); // Form'un içine bunu verdiğimizde kaydedeceği yer değişiyor.
            Form mainForm = new Form(csvSaver);

            Button btnSave = new Button(101, "btnSave", (0, 100)) {
                Text = "Save"
            };

            Button bynClose = new Button(102, "btnClose", (0, 500)) { 
                Text = "Close" };
            CheckBox isActiveProfile = new CheckBox(104, "chckIsActive", (0, 10))
            {
                Text = "Is active profile.",
                IsChecked = true
            };
            Label lblTitle = new Label(106, "lblTitle", (50, 50)) { 
                Text = "Title" };
            var dbConnector = new DbConnector(90, "dbConnector", (0, 0))
            {
                ConnectionString = "data source..."
            };

            mainForm.AddControls(btnSave, bynClose, isActiveProfile, lblTitle, dbConnector);
            mainForm.DrawAll();
            mainForm.Save();
        }
    }
}
