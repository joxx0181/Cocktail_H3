using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_H3
{
    // This class represents CocktailH3Context with inheritance from DbContext!
    class CocktailH3Context : DbContext
    {
        public CocktailH3Context() : base()
        {

        }

        // Properties to be tables in the database!
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<AlcoQuantity> AlcoQuantities { get; set; }
        public DbSet<AlcoBrand> AlcoBrands { get; set; }
        public DbSet<IngredientQuantity> IngredientQuantities { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}