using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Models
{
    public partial class DeliveryAddress
    {
        public DeliveryAddress()
        {
            TblOrder = new HashSet<Order>();
        }

        
        public int IdAddress { get; set; }
        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Customer Name is Required.")]
        public int IdCustomer { get; set; }
        [DisplayName("Street Name")]
        [Required(ErrorMessage = "Street Name is Required.")]
        public string Street { get; set; }
        [DisplayName("City Name")]
        [Required(ErrorMessage = "City Name is Required.")]
        public string City { get; set; }
        [DisplayName("Street Number")]
        [Required(ErrorMessage = "Street Number is Required.")]
        public int? Number { get; set; }

        [DisplayName("Customer Name")]
        public virtual Customer CustomerNavigation { get; set; }
        public virtual ICollection<Order> TblOrder { get; set; }
    }
}
