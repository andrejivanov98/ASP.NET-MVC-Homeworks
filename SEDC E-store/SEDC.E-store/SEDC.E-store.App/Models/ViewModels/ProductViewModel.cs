using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Enums;
using SEDC.E_store.App.Models.Domain;

namespace SEDC.E_store.App.Models.ViewModels
{
    public class ProductViewModel
    {
       public IEnumerable<Phone> Phones { get; set; }
       public IEnumerable<Laptop> Laptops { get; set; }
       public IEnumerable<Pc> Pcs { get; set; }
    }
}
