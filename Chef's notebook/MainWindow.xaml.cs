using Chefs_notebook;
using Chefs_notebook.model;
using Chefs_notebook.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chef_s_notebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RecipeManager RecipeManager;

        public MainWindow()
        {
            InitializeComponent();
            Recipe recipe1 = RecipeBuilder.Builder()
                .withName("Test1")
                .withCategories(Category.BREAKFAST, Category.DRINK)
                .withIngredients(IngredientBuilder.Builder()
                    .WithName("JAJCA")
                    .WithQuantity(2)
                    .WithUnit(Unit.PIECE)
                    .Build(), IngredientBuilder.Builder()
                    .WithName("Mleko")
                    .WithQuantity(2)
                    .WithUnit(Unit.GLASS)
                    .Build())
                .withPortions(2)
                .build();

            Recipe recipe2 = RecipeBuilder.Builder()
                .withName("Test2")
                .withCategories(Category.LUNCH, Category.VEGETARIAN)
                .withIngredients(IngredientBuilder.Builder()
                    .WithName("JAJCA")
                    .WithQuantity(2)
                    .WithUnit(Unit.PIECE)
                    .Build(), IngredientBuilder.Builder()
                    .WithName("Mleko")
                    .WithQuantity(2)
                    .WithUnit(Unit.GLASS)
                    .Build())
                .withPortions(2)
                .build();


            RecipeManager = new RecipeManager(this);
            RecipeManager.Recipes.Add(recipe1);
            RecipeManager.Recipes.Add(recipe2);
            this.Categories.ItemsSource = Enum.GetValues(typeof(Category)).Cast<Category>();
        }

        private void Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category category = ExtractCategory(sender);
            this.Recipes.ItemsSource = RecipeManager.FilterByCategory(category);
        }

        private void Recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Recipe recipe = ExtractRecipe(sender);
            RecipeManager.ShowRecipe(recipe);
        }

        private Category ExtractCategory(object combobox)
        {
            string categoryName = (combobox as ComboBox).SelectedItem.ToString();
            return (Category)Enum.Parse(typeof(Category), categoryName);
        }

        private Recipe ExtractRecipe(object listbox)
        {
            if ((listbox as ListBox).SelectedItem == null) return null;
            string recipeName = (listbox as ListBox).SelectedItem.ToString();
            return RecipeManager.FindByName(recipeName);
        }
    }
}
