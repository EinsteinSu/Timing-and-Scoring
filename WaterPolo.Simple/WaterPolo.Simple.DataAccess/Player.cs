using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterPolo.Simple.DataAccess
{
    public class Player : IDisplay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int PlayerId { get; set; }

        public string DisplayNumber { get; set; }

        [Display(AutoGenerateField = false)] public Team Team { get; set; }

        [Display(Name = "Team Name")] public string TeamName => Team?.Name;

        [ForeignKey("Team")]
        [Display(AutoGenerateField = false)]
        public int TeamId { get; set; }

        public int OrderNumber { get; set; }

        public virtual ObservableCollection<TeamMatch> TeamMatches { get; set; }

        [MaxLength(50)] public string Name { get; set; }

        [Required] [MaxLength(12)] public string DisplayName { get; set; }
    }
}