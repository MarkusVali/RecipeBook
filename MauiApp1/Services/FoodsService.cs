using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal static class FoodsService
    {
        private static List<Food> SaltyFood = new()
        {
            new()
            {
                Name = "fghgfh",
                Subtitle = "  gfhgfhg",
                HeroImage = "f.png",
                Description = "hhh",
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                }
            },

        };

        private static List<Food> Desserts = new()
        {
            new()
            {
                Name = "hjjjjj",
                Subtitle = "  jjjjj",
                HeroImage = "jjj.png",
                Description = "jjjjj",
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                }
            },

        };

        public static List<Food> GetSaltyFood()
        {
            var salty = new SaltyFood();

            return SaltyFood;
        }

        public static List<Food> GetDesserts()
        {
            var salty = new Desserts();

            return Desserts;
        }
    }
}
