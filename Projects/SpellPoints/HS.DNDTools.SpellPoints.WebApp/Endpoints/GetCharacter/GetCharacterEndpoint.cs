using HS.DNDTools.SpellPoints.Domain.Providers;
namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.GetCharacter
{
    public class GetCharacterEndpoint : Endpoint<GetCharacterRequest, GetCharacterResponse>
    {
        private readonly ICharacterProvider _characterProvider;

        public override void Configure()
        {
            this.Get("/api/v1/character/{Id}");
            this.AllowAnonymous();
        }

        public GetCharacterEndpoint(ICharacterProvider characterProvider)
        {
            this._characterProvider = characterProvider;
        }
        public override async Task HandleAsync(GetCharacterRequest req, CancellationToken ct)
        {
            await SendAsync(new GetCharacterResponse { Character = _characterProvider.GetCharacter(req.Id) });
        }
    }
}
