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

        [Display(Name = "Display Number", Order = 1)]
        public string DisplayNumber { get; set; }

        [Display(AutoGenerateField = false)] public Team Team { get; set; }

        [Display(Name = "Upper case Name", Order = 3)]
        public string UppercaseName => Name.ToUpper();

        [Display(AutoGenerateField = false)] public string TeamName => Team?.Name;

        public virtual ObservableCollection<TeamMatch> TeamMatches { get; set; }

        [ForeignKey("Team")]
        [Display(AutoGenerateField = false)]
        public int TeamId { get; set; }

        [Display(Name = "Order Number", Order = 0)]
        public int OrderNumber { get; set; }

        [Display(Order = 2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Order = 4)]
        [Required]
        [MaxLength(20)]
        public string DisplayName { get; set; }

        public override string ToString()
        {
            return $"{DisplayNumber} : {Name}";
        }
    }
}