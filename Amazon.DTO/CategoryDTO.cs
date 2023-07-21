using System.ComponentModel.DataAnnotations;

namespace Amazon.DTO
{
	public class CategoryDTO
	{
		public int Id { get; set; }
		[MinLength( 5, ErrorMessage = "Name Length Must Be Between 3 to 50 char")]
		public string Name { get; set; }
        public int? categoryId { get; set; }
	}
}