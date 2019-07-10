using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;

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

        [Display(Name = "Upper case Name")]
        public string UppercaseName => Name.ToUpper();

        [Display(Name = "Team Name")] public string TeamName => Team?.Name;

        public virtual ObservableCollection<TeamMatch> TeamMatches { get; set; }

        [ForeignKey("Team")]
        [Display(AutoGenerateField = false)]
        public int TeamId { get; set; }

        public int OrderNumber { get; set; }

        [MaxLength(50)] public string Name { get; set; }

        [Required] [MaxLength(20)] public string DisplayName { get; set; }

        public override string ToString()
        {
            return $"{DisplayNumber} : {Name}";
        }
    }
}