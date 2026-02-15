namespace HeroGenerator.Core.Common
{
    public static class EntityValidationParams
    {
        public class HeroValidationParams
        {
            public const int HeroNameMaxLength = 50;
            public const int HeroDescriptionMaxLength = 500;
        }
        public class HeroRaceValidation
        {
            public const int RaceNameMinLength = 2;
            public const int RaceNameMaxLength = 30;
        }
        public class HeroEquipmentValidation
        {
            public const int EquipmentNameMaxLength = 50;
            public const int EquipmentNameMinLength = 3;

            public const int EquipmentTypeMaxLength = 20;
            public const int EquipmentTypeMinLength = 3;
        }
    }
}
