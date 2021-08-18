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
       public List<Phone> Phones { get; set; }
       public List<Laptop> Laptops { get; set; }
       public List<Pc> Pcs { get; set; }
    }
}
