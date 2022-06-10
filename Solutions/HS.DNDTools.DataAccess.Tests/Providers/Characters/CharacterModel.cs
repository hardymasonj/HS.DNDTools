using HS.DNDTools.SpellPoints.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.DataAccess.Tests.Providers.Characters
{
    internal class CharacterModel : ICharacter
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int CurrentSpellPoints { get; set; }

        public int MaxSpellPoints { get; set; }

        public int Level { get; set; }
    }
}
