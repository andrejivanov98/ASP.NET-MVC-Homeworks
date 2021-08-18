using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Enums;

namespace SEDC.E_store.App.Models.Domain
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public List<Review> Reviews { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
