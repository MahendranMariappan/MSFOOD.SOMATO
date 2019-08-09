using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class OrderItem
    {
        
        public int IdOrderItem { get; set; }
        [DisplayName("Order ID")]
        public int IdOrder { get; set; }
        [DisplayName("Restaurant Menu Item ID")]
        public int IdRestaurantMenuItem { get; set; }
        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }
        [DisplayName("Price Per Unity")]
        public decimal PricePerUnity { get; set; }

        public virtual Order OrderNavigation { get; set; }

        public RestaurantMenuItem RestaurantMenuItemNavigation { get; set; }
    }
}
