using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArsenalFanPage.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [DisplayName("Previous Clubs")]
        public string PreviousClubs { get; set; }
        [DisplayName("Twitter Link")]
        public string TwitterLink { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [ValidateNever]
        [DisplayName("Image URL")]
        public string ImageURL { get; set; }
    }
}
