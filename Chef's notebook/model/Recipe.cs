using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefs_notebook
{
    class Recipe
    {
        public string Name { get; set; }
        public int Portions { get; set; }
        public string Preparation { get; set; }
        public string Notes { get; set; }
        public string Sources { get; set; }

        public List<Ingredient> Ingredients { get; }
        public List<Category> Categories { get; }

        public Recipe()
        {
            this.Name = String.Empty;
            this.Portions = 0;
            this.Preparation = String.Empty;
            this.Notes = String.Empty;
            this.Sources = String.Empty;

            this.Ingredients = new List<Ingredient>();
            this.Categories = new List<Category>();
        }

        public Recipe(Recipe recipe)
        {
            this.Name = recipe.Name;
            this.Portions = recipe.Portions;
            this.Preparation = recipe.Preparation;
            this.Notes = recipe.Notes;
            this.Sources = recipe.Sources;

            this.Ingredients = recipe.Ingredients;
            this.Categories = recipe.Categories;
        }
        
        public void AddIngredient(Ingredient ingredient)
        {
            this.Ingredients.Add(ingredient);
        }

        public void AddCategory(Category category)
        {
            this.Categories.Add(category);
        }        
    }
}
