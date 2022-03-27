using HS.DNDTools.SpellPoints.Domain.Characters;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CharacterList
{
    public class CharacterListResponse
    {
        public IEnumerable<ICharacter> Characters { get; set; }
    }
}
