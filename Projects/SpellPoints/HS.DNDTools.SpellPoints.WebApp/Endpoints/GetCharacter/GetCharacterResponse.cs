using HS.DNDTools.SpellPoints.Domain.Characters;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.GetCharacter
{
    public class GetCharacterResponse
    {
        public ICharacter Character { get; internal set; }
    }
}