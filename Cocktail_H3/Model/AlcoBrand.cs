using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cocktail_H3
{
    // This class represents AlcoBrand!
    public class AlcoBrand
    {
        // The Key attribute is the PrimaryKey!
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
