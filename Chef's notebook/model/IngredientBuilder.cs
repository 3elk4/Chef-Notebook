using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefs_notebook.model
{
    class IngredientBuilder
    {
        private Ingredient ingredient;

        public static IngredientBuilder Builder()
        {
            return new IngredientBuilder();
        }

        private IngredientBuilder()
        {
            ingredient = new Ingredient();
        }

        public IngredientBuilder WithName(string name)
        {
            ingredient.Name = name;
            return this;
        }

        public IngredientBuilder WithQuantity(double quantity)
        {
            ingredient.Quantity = quantity;
            return this;
        }

        public IngredientBuilder WithUnit(Unit unit)
        {
            ingredient.Unit = unit;
            return this;
        }

        public Ingredient Build()
        {
            return ingredient;
        }
    }
}
