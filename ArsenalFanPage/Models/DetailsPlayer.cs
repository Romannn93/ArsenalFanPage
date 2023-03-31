using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArsenalFanPage.Models
{
	public class DetailsPlayer
	{
		public int Id { get; set; }
		public int PlayerId { get; set; }


		[ForeignKey("PlayerId")]
		[ValidateNever]
		public Player Player { get; set; }
	}
}
