using HS.DNDTools.SpellPoints.Application.Actions;
using HS.DNDTools.SpellPoints.WebApp.Models;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CreateCharacter
{
    public class CreateCharacterEndpoint : Endpoint<CreateCharacterRequest, CreateCharacterResponse, CreateCharacterMapper>
    {
        public override void Configure()
        {
            this.Get("api/v1/new-character/{Name}/{Level}");
            this.AllowAnonymous();
        }

        public override async Task HandleAsync(CreateCharacterRequest req, CancellationToken ct)
        {
            var response = new CreateCharacterResponse();
            response.Character = Map.ToEntity(req);
            await SendAsync(response);
        }
    }
}
