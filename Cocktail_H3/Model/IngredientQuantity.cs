using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktail_H3
{
    // This class reprecents IngredientQuantity!
    public class IngredientQuantity
    {
        // The Key attribute is the PrimaryKey!
        [Key]
        public int QtyId { get; set; }
        public double QtyNum { get; set; }
        public string QtyUnit { get; set; }

        // Foreign key for Ingred!
        public int IngredId { get; set; }
    }
}
