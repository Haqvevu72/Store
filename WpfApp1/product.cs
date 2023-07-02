using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class product
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }

        public product(string path,string name, string cost)
        {
            ImagePath = path;
            Name = name;
            Cost = cost;
        }
    }
}
