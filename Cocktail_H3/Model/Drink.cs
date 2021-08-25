using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktail_H3
{
    // This class represents Drink!
    public class Drink
    {
        // The Key attribute is the PrimaryKey!
        [Key]
        public int Id { get; set; }
        public string DrinkName { get; set; }

        // Foreign key for AlcoQty!
        public int AlcoQtyId { get; set; }
 
        // Foreign key for Qty!
        public int QtyId { get; set; }
    }
}