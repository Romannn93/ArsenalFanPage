using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArsenalFanPage.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Team1 { get; set; }
        [Required]
        public string Team2 { get; set; }
        [DisplayName("Logo Team 1")]
        [ValidateNever]
        public string LogoTeam1 { get; set; }
        [DisplayName("Logo Team 2")]
        [ValidateNever]
        public string LogoTeam2 { get; set; }
        [Required]
        [DisplayName("Date Time")]
        public string DateTime { get; set; }
        [Required]
        public string Stadium { get; set; }
        public string Score { get; set; }
        public string Scorers { get; set; }
        [Required]
        public string League { get; set; }
    }
}
