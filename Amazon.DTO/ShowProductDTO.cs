using Amazon.Domain;
using System.ComponentModel.DataAnnotations;

namespace Amazon.DTO
{
    public class ShowProductDTO
    {
        public int Id { get; set; }
        [MinLength(3, ErrorMessage = "Name Length Must Be More Than 3 Char")]
        public String Name { get; set; }

        [MinLength(3, ErrorMessage = "Name Length Must Be More Than 3 Char")]
        public String arabicName { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int UnitInStock { get; set; }
        public string Description { get; set; }
        [MinLength(3, ErrorMessage = "Name Length Must Be More Than 3 Char")]
        public string arabicDescription { get; set; }
        public List<string> images { get; set; }
        public int CategoryId { get; set; }
    }
}