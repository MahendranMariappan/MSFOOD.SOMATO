using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class Order
    {
        public Order()
        {
            TblOrderItem = new HashSet<OrderItem>();
        }

        
        public int IdOrder { get; set; }
        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Customer Name is Required.")]
        public int IdCustomer { get; set; }

        [DisplayName("Address Name")]
        [Required(ErrorMessage = "Address Name is Required.")]
        public int IdAddress { get; set; }

        [DisplayName("Payment Method")]
        [Required(ErrorMessage = "Payment Method is Required.")]
        public int IdPaymentMethod { get; set; }
        [DisplayName("Restaurant Name")]
        [Required(ErrorMessage = "Restaurant Name is Required.")]
        public int IdRestaurant { get; set; }
        [DisplayName("Order Status Name")]
        [Required(ErrorMessage = "Order Status is Required.")]
        public int? IdOrderStatus { get; set; }
        [DisplayName("Order Net Amount")]
        [Required(ErrorMessage = "Order Net Amount is Required.")]
        public decimal? OrderNetAmount { get; set; }
        [DisplayName("Order Tax")]
        [Required(ErrorMessage = "Order Tax is Required.")]
        public decimal? OrderTax { get; set; }
        [DisplayName("Order Gross Amount")]
        [Required(ErrorMessage = "Order Gross Amount is Required.")]
        public decimal? OrderGrossAmount { get; set; }
        public string CustomerNotes { get; set; }

        [DisplayName("Address")]
        public virtual DeliveryAddress AddressNavigation { get; set; }
        [DisplayName("Customer Name")]
        public virtual Customer CustomerNavigation { get; set; }
        [DisplayName("Order Status")]
        public virtual OrderStatus OrderStatusNavigation { get; set; }
        [DisplayName("Payment Method")]
        public virtual PaymentMethod PaymentMethodNavigation { get; set; }
        [DisplayName("Restaurant Name")]
        public virtual Restaurant RestaurantNavigation { get; set; }
        public virtual ICollection<OrderItem> TblOrderItem { get; set; }
    }
}
