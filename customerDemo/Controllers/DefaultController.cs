using DataAccessLayerNet.Data;
using customerDemo.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web.Http.Description;
using EntityLayer.Entities;
using BusinessLayer.Classes;

namespace customerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }

        public ApplicationDbContext DbContext => dbContext;

        public DefaultController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public ActionResult GetContacs()
        {
            CustomerGet get = new CustomerGet(dbContext);
            var result = get.GetCustomer();
            return Ok(result);

            // return Ok(dbContext.Customer.ToList());

        }

        [HttpPost]
        [Route("CustomerAdd")]
        public ActionResult AddContact(CustomerEntities addContactRequest)
        {
            CustomerAdd add = new CustomerAdd(dbContext);
            dbContext.Customer.Add(addContactRequest);
            var result = add.CustomerPost(addContactRequest);
            return Ok(addContactRequest);
        }

        [HttpPut]
        [Route("CustomerUpdate")]
        public ActionResult UpdateContact(CustomerEntities addContactRequest)
        {
            CustomerUpdate update = new CustomerUpdate(dbContext);
            var result = update.Update(addContactRequest);
            return Ok(result);
        }


        [HttpDelete]
        [Route("CustomerDelete")]
        public ActionResult DeleteContact(CustomerEntities addContactRequest)
        {
            CustomerDelete delete = new CustomerDelete(dbContext);
            var result = delete.Delete(addContactRequest);
            return Ok(result);
        }


        [Route("api/[controller]")]
        [HttpGet]
         public ActionResult GetResult()
         {
             CustomerRecord record = new CustomerRecord(dbContext);
             var result = record.CustomerCall();
             return Ok(result);
         }
    } 
}
