using System.ComponentModel.DataAnnotations;

namespace BootstrappingMvc.Models
{
    public class MoviePass
    {
        public int MoviePassId { get; set; }

        [Display(Name = "Movie Title")]
        public string MovieTitle { get; set; }

        [Display(Name = "Good for New Releases")]
        public bool? CanUseForNewReleases { get; set; }

        [Display(Name = "VIP - Skip the Line")]
        [UIHint("SwitchedBoolean")]
        public bool CanSkipLine { get; set; }

    }
}