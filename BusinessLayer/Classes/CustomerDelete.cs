using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNet.Data;
using EntityLayer.Entities;

namespace BusinessLayer.Classes
{
    public class CustomerDelete
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicationDbContext DbContext => dbContext;

        public object?[]? CustomerID { get; private set; }

        public CustomerDelete(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CustomerEntities Delete(CustomerEntities updateContactRequest)
        {
            var customer = dbContext.Customer.Find(updateContactRequest.CustomerID);

            if (customer != null)
            {
                dbContext.Remove(customer);
                dbContext.SaveChanges();

            }
            return customer;


        }
    }
}
