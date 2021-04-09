using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class location_info
    {
        [Key]
        public int LocationID { get; set; }
        public string Borough { get; set; }
        public string Zone { get; set; }
       
    }
}
