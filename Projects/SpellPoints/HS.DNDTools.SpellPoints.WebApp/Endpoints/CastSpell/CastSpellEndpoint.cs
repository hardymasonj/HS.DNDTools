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
            using (var oLogic = new SpellPoints.Application.Actions.CastSpell(req.Character))
            {
                req.Character.CurrentSpellPoints = oLogic.CastLeveledSpell(req.SpellLevel);
            }
            await SendAsync(new CastSpellResponseModel() { Character = req.Character });
        }
    }
}
