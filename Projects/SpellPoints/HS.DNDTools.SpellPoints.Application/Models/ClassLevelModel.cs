using HS.DNDTools.SpellPoints.Domain.Characters;
using HS.DNDTools.SpellPoints.Domain.Enums.ClassEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Models
{
    public class ClassLevelModel : IClassLevel
    {
        public string Name { get; set; } = string.Empty;
        public string Subclass { get; set; } = string.Empty;
        public int Level { get; set; }
        public virtual string CastingAttribute { get; } = string.Empty;
        public virtual CasterType CasterType { get; } = CasterType.None;
    }
}
