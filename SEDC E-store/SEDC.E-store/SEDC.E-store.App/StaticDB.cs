using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Domain;
using SEDC.E_store.App.Models.Enums;

namespace SEDC.E_store.App
{
    public static class StaticDB
    {
        public static List<Phone> phones = new List<Phone>
        {
            new Phone
            {
                Id = 1,
                Name = "Iphone",
                Description = "Iphone model X",
                Category = ProductCategory.Phone,
                Reviews = new List<Review>(){Review.Excellent, Review.Excellent, Review.Good, Review.Excellent},
                IsOnPromotion = false
            },
              new Phone
            {
                Id = 2,
                Name = "Samsung",
                Description = "Samsung model S20",
                Category = ProductCategory.Phone,
                Reviews = new List<Review>(){Review.Bad, Review.Excellent, Review.Good, Review.Good},
                IsOnPromotion = false
            },
                new Phone
            {
                Id = 2,
                Name = "Huawei",
                Description = "Huawei model P20",
                Category = ProductCategory.Phone,
                Reviews = new List<Review>(){Review.Good, Review.Excellent, Review.Bad, Review.Good},
                IsOnPromotion = true
            },
                  new Phone
            {
                Id = 4,
                Name = "Xiaomi",
                Description = "Xiaomie model MI10",
                Category = ProductCategory.Phone,
                Reviews = new List<Review>(){Review.Bad, Review.Excellent, Review.Good, Review.Bad},
                IsOnPromotion = true
            }

        };

        public static List<Laptop> laptops = new List<Laptop>
        {
            new Laptop
            {
                Id = 1,
                Name = "MacBook",
                Description = "Macbook model Pro",
                Category = ProductCategory.Laptop,
                Reviews = new List<Review>(){Review.Excellent, Review.Excellent, Review.Good, Review.Excellent},
                IsOnPromotion = false
            },
            new Laptop
            {
                Id = 2,
                Name = "MacBook",
                Description = "Macbook model Air",
                Category = ProductCategory.Laptop,
                Reviews = new List<Review>(){Review.Excellent, Review.Good, Review.Good, Review.Good},
                IsOnPromotion = true
            },
            new Laptop
            {
                Id = 3,
                Name = "Huawei",
                Description = "Huawei model Mat",
                Category = ProductCategory.Laptop,
                Reviews = new List<Review>(){Review.Excellent, Review.Good, Review.Good, Review.Excellent},
                IsOnPromotion = false
            },
            new Laptop
            {
                Id = 4,
                Name = "Surface",
                Description = "Surface model Pro",
                Category = ProductCategory.Laptop,
                Reviews = new List<Review>(){Review.Excellent, Review.Excellent, Review.Good, Review.Good},
                IsOnPromotion = true
            },

        };

        public static List<Pc> pcs = new List<Pc>
        {
            new Pc
            {
                Id = 1,
                Name = "Toshiba",
                Description = "Toshiba model X",
                Category = ProductCategory.Pc,
                Reviews = new List<Review>(){Review.Excellent, Review.Good, Review.Good, Review.Bad},
                IsOnPromotion = true
            },
            new Pc
            {
                Id = 2,
                Name = "Lenovo",
                Description = "Lenovo model Z",
                Category = ProductCategory.Pc,
                Reviews = new List<Review>(){Review.Bad, Review.Good, Review.Good, Review.Bad},
                IsOnPromotion = true
            },
            new Pc
            {
                Id = 3,
                Name = "Samssung",
                Description = "Samsung model XS-220",
                Category = ProductCategory.Pc,
                Reviews = new List<Review>(){Review.Good, Review.Good, Review.Good, Review.Excellent},
                IsOnPromotion = false
            },
            new Pc
            {
                Id = 4,
                Name = "IMac",
                Description = "IMac model ProX",
                Category = ProductCategory.Pc,
                Reviews = new List<Review>(){Review.Excellent, Review.Excellent, Review.Excellent, Review.Excellent},
                IsOnPromotion = false
            },
        };
    }
}
