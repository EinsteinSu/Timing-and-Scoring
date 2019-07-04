using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterPolo.Simple.DataAccess
{
    public class Schedule : IDisplay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int ScheduleId { get; set; }

        public DateTime? StartTime { get; set; }

        [Display(AutoGenerateField = false)] public DateTime? EndTime { get; set; }

        [Display(AutoGenerateField = false)] public TeamMatch TeamA { get; set; }

        [Display(AutoGenerateField = false)] public TeamMatch TeamB { get; set; }

        [MaxLength(200)] public string Name { get; set; }

        [MaxLength(50)] public string DisplayName { get; set; }
    }
}