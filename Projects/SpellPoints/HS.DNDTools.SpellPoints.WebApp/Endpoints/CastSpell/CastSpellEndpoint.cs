using HS.DNDTools.SpellPoints.Application;
namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CastSpell
{
    //https://www.dndbeyond.com/sources/dmg/dungeon-masters-workshop#VariantSpellPoints
    public class CastSpellEndpoint : Endpoint<CastSpellRequestModel, CastSpellResponseModel>
    {
        public override void Configure()
        {
            this.Post("api/v1/cast-spell");
            this.AllowAnonymous();
        }
        public async override Task HandleAsync(CastSpellRequestModel req, CancellationToken ct)
        {
            var oLogic = new Application.Actions.CastSpell();
            await(SendAsync(new CastSpellResponseModel() { NewSpellPoints = oLogic.CastLeveledSpell(req.SpellLevel, req.SpellPoints) }));
        }
    }
}
