using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ArsenalFanPage.Models
{
	public class History
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		[ValidateNever]
		public string ImageUrl { get; set; }
		public DateTime CreatedTime { get; set; }
	}
}
