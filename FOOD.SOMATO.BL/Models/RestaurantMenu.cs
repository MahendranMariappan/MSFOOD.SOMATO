using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class RestaurantMenu
    {
        public RestaurantMenu()
        {
            TblRestaurantMenuItem = new HashSet<RestaurantMenuItem>();
        }

        
        public int IdRestaurantMenu { get; set; }
        public int IdRestaurant { get; set; }
        public string MenuName { get; set; }
        public string MenuType { get; set; }

        public virtual Restaurant RestaurantNavigation { get; set; }
        public virtual ICollection<RestaurantMenuItem> TblRestaurantMenuItem { get; set; }
    }
}
