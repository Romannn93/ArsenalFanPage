using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArsenalFanPage.Models
{
	public class DetailsNews
	{
		public int Id { get; set; }
		public int NewsId { get; set; }


		[ForeignKey("NewsId")]
		[ValidateNever]
		public News News { get; set; }
	}
}
