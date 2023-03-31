using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArsenalFanPage.Models
{
	public class DetailsMatch
	{
		public int Id { get; set; }
		public int MatchId { get; set; }


		[ForeignKey("MatchId")]
		[ValidateNever]
		public Match Match { get; set; }

		public string News { get; set; }
		public string YoutubePath { get; set; }
		public string ImageUrl { get; set; }
	}
}
