using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNet.Data;
using EntityLayer.Entities;

namespace BusinessLayer.Classes
{
    public class CustomerAdd
    {
        
            private readonly ApplicationDbContext dbContext;

            public ApplicationDbContext DbContext => dbContext;


            public CustomerAdd(ApplicationDbContext dbContext)
            {
                this.dbContext = dbContext;
            }

            public CustomerEntities CustomerPost(CustomerEntities addContactRequest)
            {
                var item = dbContext.Customer.Find(addContactRequest.CustomerID);
                dbContext.Customer.Add(addContactRequest);
                return item;
            }

           
    }

}
