using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarProject
{
    internal class Car
    {

        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Year { get; set; }
        public string VINCode { get; set; }



        public override string ToString()
        {
            return $"ID {Id} - Mark {Mark} - Model {Model} - Color {Color}" +
                $" - ExpireDate {Year} - Price {Price} - VINCode {VINCode}";
        }

    }
}
