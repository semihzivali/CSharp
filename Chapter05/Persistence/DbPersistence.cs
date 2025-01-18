using Chapter05.Components;
using Chapter05.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.Persistence
{
    public class DbPersistence
        : IPersistence
    {
        public void Save(List<Control> controls)
        {
            Console.WriteLine("DB save.");
        }
    }
}
