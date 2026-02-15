using HeroGenerator.Core.Models;
using HeroGenerator.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HeroGenerator.Core.Common.EntityValidationParams.HeroValidationParams;
using static HeroGenerator.Core.Common.EntityValidationParams.HeroRaceValidation;

namespace HeroGenerator.Services.Models
{
    public class HeroServiceModel
    {
        public int Id { get; set; }
        [MaxLength(HeroNameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        public int Strength { get; set; }
        [Required]
        public int Constitution { get; set; }
        [Required]
        public int Dexterity { get; set; }
        [MaxLength(HeroDescriptionMaxLength)]
        public string? Description { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentType { get; set; }
        [MaxLength(RaceNameMaxLength)]
        [MinLength(RaceNameMinLength)]
        public string RaceName { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
