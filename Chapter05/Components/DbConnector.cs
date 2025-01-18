﻿
using static System.Net.Mime.MediaTypeNames;

namespace Chapter05.Components
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
