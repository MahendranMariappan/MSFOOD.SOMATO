using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery.Models;

namespace FOOD.SOMATO.BL.Interfaces
{
    public class ICustomerRepository : IRepository<Customer>
    {
        public IEnumerable<Customer> GetAll
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
