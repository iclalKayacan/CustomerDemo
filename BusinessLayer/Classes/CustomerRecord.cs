
using DataAccessLayerNet.Data;
using EntityLayer.Entities;
using System.Collections;


namespace BusinessLayer.Classes
{
    public class CustomerRecord
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicationDbContext DbContext => dbContext;

        public CustomerRecord(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<CustomerDto> CustomerCall()
        {
                var item = from customer in dbContext.Customer
                           join customerAddress in dbContext.CustomerAddress on customer.CustomerID equals customerAddress.AddressId

                          select new CustomerDto
                          {
                              CustomerID = customer.CustomerID,
                              FirstName = customer.FirstName,
                              LastName = customer.LastName,
                              Mail = customer.Mail,
                              Address = customerAddress.Address,
                          };

            return item.ToList();   

        }
    }
}
