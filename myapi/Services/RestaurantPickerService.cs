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
                { "Mexican", new List<string>{ "El Sol","Taco Loco","Casa Maya","La Fiesta","El Toro","Cocina Azteca","Taqueria La Palmas","Taco King","Taco Bell","El Pollo Feliz"} },
                { "Italian", new List<string>{ "Luigi's","Roma","Pasta House","Bella","Napoli","Mario's","Villa","Olive Garden"} },
                { "Asian", new List<string>{"88 Bao Bao","Johnny Wokker Downtown", "Sherman's Chinese Buffet", "Sun's Garden", "Oishii Hibachi Japenese Grill"} }
            };

        public string PickRestaurant(string category)
        {
            if(!_restaurants.ContainsKey(category))
            return "Invalid category please enter Mexican, Italian or Asian";

            var list = _restaurants[category];
            int index = _random.Next(list.Count);
            return list[index];
            
        }


    }
}