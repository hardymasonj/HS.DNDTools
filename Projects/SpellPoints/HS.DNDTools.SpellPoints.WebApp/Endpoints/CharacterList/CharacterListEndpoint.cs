using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Providers;
using HS.DNDTools.SpellPoints.WebApp.Models;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CharacterList
{
    public class CharacterListEndpoint : Endpoint<CharacterListRequest, CharacterListResponse>
    {
        private ICharacterListProvider _characterProvider = null;
        public CharacterListEndpoint(ICharacterListProvider characterProvider)
        {
            this._characterProvider = characterProvider;
        }
        public override void Configure()
        {
            //This would be authenticated long term, just practicing now
            this.Get("api/v1/character-list/{UserId}");
            this.AllowAnonymous();
        }
        public override async Task HandleAsync(CharacterListRequest req, CancellationToken ct)
        {
            await SendAsync(new CharacterListResponse { Characters = _characterProvider.GetCharacters() });
        }
    }
}
