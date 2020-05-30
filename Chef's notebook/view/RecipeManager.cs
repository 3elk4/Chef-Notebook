using Chef_s_notebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefs_notebook.view
{
    class RecipeManager
    {
        private const String CATEGORY_FORMAT = "{0}, ";
        private const String INGREDIENT_FORMAT = "   > {0}\n";

        private MainWindow mainWindow;
        public List<Recipe> Recipes { get; set; } // temporary

        public RecipeManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            Recipes = new List<Recipe>();
        }

        public IEnumerable<string> FilterByCategory(Category category)
        {
            return Recipes
                .FindAll(recipe => recipe.Categories.Contains(category))
                .Select(recipe => recipe.Name);
        }

        public Recipe FindByName(string name)
        {
            return Recipes.Find(recipe => recipe.Name.Equals(name));
        }

        public void ShowRecipe(Recipe recipe)
        {
            if (recipe == null) return;
            mainWindow.RecipeName.Text = recipe.Name;
            mainWindow.RecipePortion.Text = recipe.Portions.ToString();
            mainWindow.RecipePreparation.Text = recipe.Preparation;
            mainWindow.RecipeNotes.Text = recipe.Notes;
            mainWindow.RecipeSources.Text = recipe.Sources;
            mainWindow.RecipeCategory.Text = ConvertCategories(CATEGORY_FORMAT, recipe.Categories);
            mainWindow.RecipeIngredients.Text = ConvertIngredients(INGREDIENT_FORMAT, recipe.Ingredients);
        }

        private string ConvertCategories(string format, List<Category> items)
        {
            StringBuilder result = new StringBuilder();
            items.ForEach(item => result.AppendFormat(format, item.ToString()));
            return result.ToString();
        }

        private string ConvertIngredients(string format, List<Ingredient> items)
        {
            StringBuilder result = new StringBuilder();
            items.ForEach(item => result.AppendFormat(format, item.ToString()));
            return result.ToString();
        }

        private void SaveRecipe()
        {

        }
    }
}
