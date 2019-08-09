using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FoodDelivery.Models
{
    public partial class Customer
    {
        public Customer()
        {
            TblDeliveryAddress = new HashSet<DeliveryAddress>();
            TblOrder = new HashSet<Order>();
            TblPaymentMethod = new HashSet<PaymentMethod>();
        }

        
        public int IdCustomer { get; set; }
        [Required]
        [Display(Name="Customer Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Customer Phone")]
        public int Phone { get; set; }
        [Required]
        [Display(Name = "Customer Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Customer Password")]
        public byte[] Password { get; set; }

        public virtual ICollection<DeliveryAddress> TblDeliveryAddress { get; set; }
        public virtual ICollection<Order> TblOrder { get; set; }
        public virtual ICollection<PaymentMethod> TblPaymentMethod { get; set; }
    }
}
