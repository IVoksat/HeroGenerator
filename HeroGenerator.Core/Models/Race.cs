using System.ComponentModel.DataAnnotations;

namespace HeroGenerator.Core.Models
{
    using static HeroGenerator.Core.Common.EntityValidationParams.HeroRaceValidation;
    public class Race
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RaceNameMaxLength)]
        public string Name { get; set; } = null!;
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }

        public virtual ICollection<Hero> Heroes { get; set; } = new HashSet<Hero>();

    }
}
