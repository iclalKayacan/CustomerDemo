using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNet.Data;
using EntityLayer.Entities;

namespace BusinessLayer.Classes
{
    public class CustomerGet
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicationDbContext DbContext => dbContext;

        public object?[]? CustomerID { get; set; }

        public CustomerGet(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<CustomerEntities> GetCustomer()
        {
            
             var item = from customer in dbContext.Customer

                        select new CustomerEntities
                        {
                               CustomerID = customer.CustomerID,
                               FirstName = customer.FirstName,
                               LastName = customer.LastName,
                               City = customer.City,
                               Mail = customer.Mail,
                               Phone = customer.Phone,
                        };

                return item.ToList();


        }

     
    }
}
