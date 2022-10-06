using System.ComponentModel.DataAnnotations;

namespace WebAPI_WithDBLTIDB.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


    }
}
