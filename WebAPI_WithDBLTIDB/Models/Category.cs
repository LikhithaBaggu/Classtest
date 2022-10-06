using System.ComponentModel.DataAnnotations;

namespace WebAPI_WithDBLTIDB.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
      
    }
}
