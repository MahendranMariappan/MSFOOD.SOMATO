using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class RestaurantMenuItem
    {
        
        public int IdRestaurantMenuItem { get; set; }
        public int IdRestaurantMenu { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }

        public virtual RestaurantMenu RestaurantMenuNavigation { get; set; }
        public ICollection<OrderItem> TblOrderItem { get; set; }

    }
}
