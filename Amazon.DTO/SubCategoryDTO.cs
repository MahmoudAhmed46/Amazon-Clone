﻿using Amazon.Domain;
using System.ComponentModel.DataAnnotations;

namespace Amazon.DTO
{
	public class SubCategoryDTO
	{
		public int Id { get; set; }
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name Length Must Be Between 3 to 50 char")]
		public string Name { get; set; }
        public int? categoryId { get; set; }

		public string? imageName { get; set; }

	}
}