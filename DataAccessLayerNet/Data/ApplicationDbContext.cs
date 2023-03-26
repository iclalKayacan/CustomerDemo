using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayerNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public readonly object CustomerEntities;


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerEntities> Customer { get; set; }
        public DbSet<CustomerAddressEntities> CustomerAddress { get; set; }


    }
}