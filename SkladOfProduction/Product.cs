using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladOfProduction
{
    public class Product
    {
        public string Name { get; set; }
        public int OstatokDney { get; set; }
        public DateTime DataPostupleniya { get; set; }
        public Product(string name, int ostatokDney, DateTime dataPostupleniya = default)
        {
            Name = name;
            this.OstatokDney = ostatokDney;
            this.DataPostupleniya = dataPostupleniya;
        }
    }
}
