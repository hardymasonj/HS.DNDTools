using HS.DNDTools.SpellPoints.WebApp.Models;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CreateCharacter
{
    public class CreateCharacterMapper : Mapper<CreateCharacterRequest, CreateCharacterResponse, CharacterModel>
    {
        public override CharacterModel ToEntity(CreateCharacterRequest r)
        {
            var model = new CharacterModel();
            
            model.Name = r.Name;
            model.Level = r.Level;
            model.MaxSpellPoints = (new SpellPoints.Application.Actions.MaxSpellPoints()).CalculateForLevel(model.Level);
            model.CurrentSpellPoints = model.MaxSpellPoints;
            model.Id = Guid.NewGuid().ToString();

            return model;
        }
    }
}
