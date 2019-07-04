using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterPolo.Simple.DataAccess
{
    public class Team : IDisplay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int TeamId { get; set; }

        public byte[] Flag { get; set; }

        [Display(AutoGenerateField = false)] public virtual ObservableCollection<Player> Players { get; set; }

        [MaxLength(50)] public string Name { get; set; }

        [Required] [MaxLength(4)] public string DisplayName { get; set; }
    }
}