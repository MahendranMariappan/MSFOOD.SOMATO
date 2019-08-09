using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            TblOrder = new HashSet<Order>();
        }

        
        public int IdPaymentMethod { get; set; }
        [DisplayName("Customer ID")]
        public int IdCustomer { get; set; }
        [DisplayName("Card Number")]
        public int CardNumber { get; set; }
        [DisplayName("Expire Date")]
        public DateTime ExpireDate { get; set; }
        [DisplayName("Security Code")]
        public int SecurityCode { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual ICollection<Order> TblOrder { get; set; }
    }
}
