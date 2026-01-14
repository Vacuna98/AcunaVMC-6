using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Services;

namespace Services
{
    public class RestaurantPickerService
    {
        private readonly Random _random = new();

        private Dictionary<string, List<string>> _restaurants =
            new Dictionary<string, List<string>>()
            {
                { "Mexican", new List<string>{ "El Sol","Taco Loco","Casa Maya","La Fiesta","El Toro","Azteca","La Palma","Taco King","Mi Rancho","El Gallo"} },
                { "Italian", new List<string>{ "Luigi’s","Roma","Pasta House","Bella","Napoli","Mario’s","Villa","Olive Tree","Capri","Nonna’s"} }
            };

        public string PickRestaurant(string category)
        {
            if(!_restaurants.ContainsKey(category))
            return "Invalid category";

            var list = _restaurants[category];
            int index = _random.Next(list.Count);
            return list[index];
            
        }


    }
}