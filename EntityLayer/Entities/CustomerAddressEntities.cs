using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class CustomerAddressEntities
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
