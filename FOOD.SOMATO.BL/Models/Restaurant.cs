using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            TblOrder = new HashSet<Order>();
            TblRestaurantMenu = new HashSet<RestaurantMenu>();
        }

        
        public int IdRestaurant { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Order> TblOrder { get; set; }
        public virtual ICollection<RestaurantMenu> TblRestaurantMenu { get; set; }
    }
}
