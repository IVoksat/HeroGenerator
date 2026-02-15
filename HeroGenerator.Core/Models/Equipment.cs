using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGenerator.Core.Models
{
    using static HeroGenerator.Core.Common.EntityValidationParams.HeroEquipmentValidation;
    public class Equipment
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(EquipmentNameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(EquipmentTypeMaxLength)]
        public string Type { get; set; } = null!;

        public virtual ICollection<Hero> Heroes { get; set; } = new HashSet<Hero>();

    }
}
