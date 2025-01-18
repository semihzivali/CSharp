using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.Components
{
    public abstract class Control
    {
        public int Id { get; set; }
        protected string Name { get; set; }
        protected (double, double) Position { get; set; }    // bu tip tuple dır.

        protected Control(int id, string name, (double,double) position) 
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Id}|{this.GetType().Name}|{Name}|{Position}|";
        }
    }
}
