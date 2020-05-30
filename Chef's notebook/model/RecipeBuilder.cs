using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefs_notebook
{
    class RecipeBuilder
    {
        private Recipe recipe;
        
        public static RecipeBuilder Builder()
        {
            return new RecipeBuilder();
        }

        private RecipeBuilder()
        {
            recipe = new Recipe();
        }

        public RecipeBuilder withName(string name)
        {
            recipe.Name = name;
            return this;
        }

        public RecipeBuilder withPortions(int portions)
        {
            recipe.Portions = portions;
            return this;
        }

        public RecipeBuilder withPreparations(string preparation)
        {
            recipe.Preparation = preparation;
            return this;
        }

        public RecipeBuilder withNotes(string notes)
        {
            recipe.Notes = notes;
            return this;
        }

        public RecipeBuilder withSources(string sources)
        {
            recipe.Sources = sources;
            return this;
        }

        public RecipeBuilder withIngredients(params Ingredient[] ingredients)
        {
            foreach(Ingredient ingredient in ingredients)
            {
                recipe.AddIngredient(ingredient);
            }
            return this;
        }

        public RecipeBuilder withCategories(params Category[] categories)
        {
            foreach (Category category in categories)
            {
                recipe.AddCategory(category);
            }
            return this;
        }

        public Recipe build()
        {
            return recipe;
        }
    }
}
