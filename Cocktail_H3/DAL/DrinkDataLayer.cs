using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_H3
{
    // This class represents DrinkDataLayer with inheritance from IDrinkDataLayer!
    public class DrinkDataLayer : IDrinkDataLayer
    {
        public List<Drink> LoadDrinkData()
        {
            List<Drink> drinkD = new List<Drink>
            {
               new Drink { Id = 1, DrinkName = "Screwdriver", AlcoQtyId= 1, QtyId= 1 },
               new Drink { Id = 2, DrinkName = "Bellini", AlcoQtyId= 2, QtyId= 2 },
               new Drink { Id = 3, DrinkName = "Mojito", AlcoQtyId= 3, QtyId= 3 },
               new Drink { Id = 4, DrinkName = "Daiquiri", AlcoQtyId= 4, QtyId= 4 },
            };

            using (CocktailH3Context ctx = new CocktailH3Context())
            {              
                ctx.Drinks.AddRange(drinkD);
                ctx.SaveChanges();
            }
            return drinkD;
        }

        public List<AlcoQuantity> LoadAlcoQtyData()
        {
            List<AlcoQuantity> drinkAQ = new List<AlcoQuantity>
            {
                new AlcoQuantity { AlcoQtyId=1, AlcoQtyNum=45, AlcoQtyUnit="ml.", BrandId = 1 },
                new AlcoQuantity { AlcoQtyId=2, AlcoQtyNum=100, AlcoQtyUnit="ml.", BrandId = 2 },
                new AlcoQuantity { AlcoQtyId=3, AlcoQtyNum=50, AlcoQtyUnit="ml.", BrandId = 3 },
                new AlcoQuantity { AlcoQtyId=4, AlcoQtyNum=45, AlcoQtyUnit="ml.", BrandId = 4 },
            };

            using (CocktailH3Context ctx = new CocktailH3Context())
            {
                ctx.AlcoQuantities.AddRange(drinkAQ);
                ctx.SaveChanges();
            }
            return drinkAQ;
        }

        public List<AlcoBrand> LoadAlcoBrandData()
        {
            List<AlcoBrand> drinkAB = new List<AlcoBrand>()
            {
                new AlcoBrand { BrandId=1, BrandName="Vodka"},
                new AlcoBrand { BrandId=2, BrandName="Prosecco"},
                new AlcoBrand { BrandId=3, BrandName="White Rum"},
                new AlcoBrand { BrandId=4, BrandName="White Rum"},
            };

            using (CocktailH3Context ctx = new CocktailH3Context())
            {
                ctx.AlcoBrands.AddRange(drinkAB);
                ctx.SaveChanges();
            }
            return drinkAB;
        }

        public List<IngredientQuantity> LoadIngredientQtyData()
        {
            List<IngredientQuantity> drinkIQ = new List<IngredientQuantity>()
            {
                new IngredientQuantity { QtyId=1, QtyNum=135, QtyUnit="ml.", IngredId= 1 },
                new IngredientQuantity { QtyId=2, QtyNum=50, QtyUnit="ml.", IngredId= 2 },
                new IngredientQuantity { QtyId=3, QtyNum=20, QtyUnit="ml.", IngredId= 3 },
                new IngredientQuantity { QtyId=4, QtyNum=25, QtyUnit="ml.", IngredId= 4 },
            };

            using (CocktailH3Context ctx = new CocktailH3Context())
            {
                ctx.IngredientQuantities.AddRange(drinkIQ);
                ctx.SaveChanges();
            }
            return drinkIQ;
        }

        public List<Ingredient> LoadIngredientData()
        {
            List<Ingredient> drinkI = new List<Ingredient>()
            {
                new Ingredient { IngredId=1, IngredName="Orange Juice"},
                new Ingredient { IngredId=2, IngredName="Peach Puree"},
                new Ingredient { IngredId=3, IngredName="Lime Juice"},
                new Ingredient { IngredId=4, IngredName="Lemon Juice"},
            };

            using (CocktailH3Context ctx = new CocktailH3Context())
            {
                ctx.Ingredients.AddRange(drinkI);
                ctx.SaveChanges();
            }
            return drinkI;
        }
    }
}
