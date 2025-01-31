﻿using Azon.Web.Persistence;
using Azon.Web.Sdk.Components;

namespace Azon.Web.Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvSaver = new CsvPersistence();
            Form mainForm = new Form(csvSaver);

            Button btnSave = new Button(101, "btnSave", (0, 100))
            {
                Text = "Save"
            };

            Button bynClose = new Button(102, "btnClose", (0, 500))
            {
                Text = "Close"
            };
            CheckBox isActiveProfile = new CheckBox(104, "chckIsActive", (0, 10))
            {
                Text = "Is active profile.",
                IsChecked = true
            };
            Label lblTitle = new Label(106, "lblTitle", (50, 50))
            {
                Text = "Title"
            };
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
