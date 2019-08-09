using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOOD.SOMATO.BL.Interfaces;
using FoodDelivery.Models;

namespace FOOD.SOMATO.BL.Services
{
    public class OrderService : IOrderRepository

    {
        public IEnumerable<Order> GetAll
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
