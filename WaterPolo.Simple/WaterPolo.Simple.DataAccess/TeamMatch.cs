using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterPolo.Simple.DataAccess
{
    public class TeamMatch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamMatchId { get; set; }

        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        public int TeamId { get; set; }

        public CapColor CapColor { get; set; }

        public int Score { get; set; }

        public virtual ObservableCollection<Player> Players { get; set; }
    }

    public enum CapColor
    {
        White, Blue
    }
}