using HS.DNDTools.SpellPoints.WebApp.Models;

namespace HS.DNDTools.SpellPoints.WebApp.Endpoints.CastSpell
{
    public class CastSpellRequestModel
    {
        public CharacterModel Character { get; set; }
        public int SpellLevel { get; set; }
    }
}
