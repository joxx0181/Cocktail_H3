using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cocktail_H3
{
    // This class reprecents Ingredient!
    public class Ingredient
    {
        // The Key attribute is the PrimaryKey!
        [Key]
        public int IngredId { get; set; }
        public string IngredName { get; set; }
    }
}
