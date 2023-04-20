using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArsenalFanPage.Models
{
	public class DetailsHistory
	{
		public int Id { get; set; }
		public int HistoryId { get; set; }


		[ForeignKey("HistoryId")]
		[ValidateNever]
		public History History { get; set; }
	}
}
