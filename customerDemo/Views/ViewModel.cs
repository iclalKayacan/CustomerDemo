
using EntityLayer.Entities;

namespace customerDemo.Views
{
    public class ViewModel
    {
        public CustomerEntities? customer { get; set; }
        public CustomerAddressEntities? customerAddress { get; set; }

        public int CustomerID { get; set; }
    }
}
