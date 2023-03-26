using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Entities
{
    public class CustomerEntities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }


    }
}
