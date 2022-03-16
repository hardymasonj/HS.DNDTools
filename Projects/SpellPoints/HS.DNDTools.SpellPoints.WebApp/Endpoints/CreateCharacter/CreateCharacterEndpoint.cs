using HS.DNDTools.SpellPoints.Application.Actions;
using HS.DNDTools.SpellPoints.WebApp.Models;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CreateCharacter
{
    public class CreateCharacterEndpoint : Endpoint<CreateCharacterRequest, CreateCharacterResponse>
    {
        public override void Configure()
        {
            this.Get("api/v1/new-character/{Name}/{Level}");
            this.AllowAnonymous();
        }

        public override async Task HandleAsync(CreateCharacterRequest req, CancellationToken ct)
        {
            var response = new CreateCharacterResponse();
            response.Character = new CharacterModel();
            response.Character.Name = req.Name;
            response.Character.MaxSpellPoints = (new MaxSpellPoints()).CalculateForLevel(req.Level);
            response.Character.CurrentSpellPoints = response.Character.MaxSpellPoints;
            response.Character.Level = req.Level;
            await SendAsync(response);
        }
    }
}
