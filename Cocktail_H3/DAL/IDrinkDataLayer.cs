using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_H3
{
    // This interface represents IDrinkDataLayer!
    interface IDrinkDataLayer
    {
        List<Drink> LoadDrinkData();

        List<AlcoQuantity> LoadAlcoQtyData();

        List<AlcoBrand> LoadAlcoBrandData();

        List<IngredientQuantity> LoadIngredientQtyData();

        List<Ingredient> LoadIngredientData();

    }
}
