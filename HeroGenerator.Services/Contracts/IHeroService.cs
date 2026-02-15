using HeroGenerator.Services.Models;

namespace HeroGenerator.Services.Contracts
{
     using HeroGenerator;
    public interface IHeroService
    {
        void GenerateHero(HeroServiceModel model);
        void UpdateHero(HeroServiceModel model);
        void DeleteHero(int id);
        HeroServiceModel GetHeroById(int id);
        IEnumerable<HeroServiceModel> GetAllHeroes();
    }
}
