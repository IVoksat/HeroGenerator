using HeroGenerator.Core.Common;
using HeroGenerator.Core.Models;
using HeroGenerator.Services.Contracts;
using HeroGenerator.Services.Models;

namespace HeroGenerator.Services.Core

{
    public class HeroService(IRepository repository) : IHeroService 
    {
        public void GenerateHero(HeroServiceModel model)
        {
            throw new NotImplementedException();
        }
        public void DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HeroServiceModel> GetAllHeroes()
        {

            return repository.GetAll<Hero>().Select(h => new HeroServiceModel()
            {
                Id = h.Id,
                Name = h.Name,
                Strength = h.Strength,
                Constitution = h.Constitution,
                Dexterity = h.Dexterity,
                Description = h.Description,
                RaceName = h.Race.Name,
                IsDeleted = h.IsDeleted == false,
            });
        }  
        public HeroServiceModel GetHeroById(int id)
        {
            HeroServiceModel hero = repository.GetById<HeroServiceModel>(id);

            return hero;
        }

        public void UpdateHero(HeroServiceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
