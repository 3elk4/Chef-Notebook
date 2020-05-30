using Chefs_notebook.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefs_notebook
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public Unit Unit { get; set; }

        public Ingredient()
        {
            this.Name = String.Empty;
            this.Quantity = 0.0;
            this.Unit = Unit.NO_UNIT;
        }

        public override string ToString()
        {
            return Name + "    -    " + Quantity.ToString() + "( " + Unit.ToString() + " )";
        }
    }
}
