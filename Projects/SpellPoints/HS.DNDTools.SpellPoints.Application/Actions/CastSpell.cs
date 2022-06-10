using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions
{
    public class CastSpell : IDisposable
    {
        public CastSpell(ICharacter character) => _character = character; //Awesome constructor is awesome
        private ICharacter _character = null;

        public int CastLeveledSpell(int spellLevel)
        {
            //https://www.dndbeyond.com/sources/dmg/dungeon-masters-workshop#VariantSpellPoints
            //basic version, this is really not how it should work, we should import rules
            int spellCost = this.GetSpellCost(spellLevel);
            if (this._character.CurrentSpellPoints < spellCost) throw new Exception("Insufficient spell points");
            return this._character.CurrentSpellPoints - spellCost;
        }
        protected virtual int GetSpellCost(int spellLevel)
        {
            switch (spellLevel)
            {
                case 1:
                    return 2;
                case 2:
                    return 3;
                case 3:
                    return 5;
                case 4:
                    return 6;
                case 5:
                    return 7;
                case 6:
                    return 9;
                case 7:
                    return 10;
                case 8:
                    return 11;
                case 9:
                    return 13;
                default:
                    throw new Exception("Spell level does not match.");
            }
        }
        public void Dispose()
        {
            _character = null; //Unmanaged, I just want to make sure garbage gets collected properly
        }
    }
}
