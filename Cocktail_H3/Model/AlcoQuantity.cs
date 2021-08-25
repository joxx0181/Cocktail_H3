using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktail_H3
{
    // This class represents AlcoQuantity!
    public class AlcoQuantity 
    {
        // The Key attribute is the PrimaryKey!
        [Key]
        public int AlcoQtyId { get; set; }
        public double AlcoQtyNum { get; set; }
        public string AlcoQtyUnit { get; set; }

        // Foreign key for Brand!
        public int BrandId { get; set; }
    }
}
