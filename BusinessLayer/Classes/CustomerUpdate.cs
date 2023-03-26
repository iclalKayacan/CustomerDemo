using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNet.Data;
using EntityLayer.Entities;

namespace BusinessLayer.Classes
{
    public class CustomerUpdate
    {
        private readonly ApplicationDbContext dbContext;
        

        public ApplicationDbContext DbContext => dbContext;
        public CustomerUpdate(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CustomerEntities Update( CustomerEntities updateContactRequest)
        {
            var customer = dbContext.Customer.Find(updateContactRequest.CustomerID);

            if (customer != null)
            {
                customer.FirstName = updateContactRequest.FirstName;
                customer.LastName = updateContactRequest.LastName;
                customer.City = updateContactRequest.City;
                customer.Mail = updateContactRequest.Mail;
                customer.Phone = updateContactRequest.Phone;

                dbContext.SaveChanges();
            }

            return customer;
        }

    
      
    }
}
