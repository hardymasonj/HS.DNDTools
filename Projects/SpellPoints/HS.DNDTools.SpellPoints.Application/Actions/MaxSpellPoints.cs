using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.SpellPoints.Application.Actions
{
    public class MaxSpellPoints
    {
        public int CalculateForLevel(int level)
        {
            return this.CalculatForLevel(level, 0, 0, 0);
        }
        public int CalculatForLevel(int fullCaster, int halfCaster, int thirdCaster, int nonCaster)
        {
            switch (fullCaster)
            {
                case 1:
                    return 4;
                case 2:
                    return 5;
                case 3:
                    return 14;
                case 4:
                    return 17;
                case 5:
                    return 27;
                case 6:
                    return 32;
                case 7:
                    return 38;
                case 8:
                    return 44;
                case 9:
                    return 57;
                case 10:
                    return 64;
                case 11:
                    return 73;
                case 12:
                    return 73;
                case 13:
                    return 83;
                case 14:
                    return 83;
                case 15:
                    return 94;
                case 16:
                    return 94;
                case 17:
                    return 107;
                case 18:
                    return 114;
                case 19:
                    return 123;
                case 20:
                    return 133;
                default:
                    throw new Exception("Spell Points only available for levels 1-20");
            }
        }
    }
}
