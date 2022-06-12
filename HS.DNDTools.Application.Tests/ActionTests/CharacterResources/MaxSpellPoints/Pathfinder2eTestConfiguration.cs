using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.DNDTools.Application.Tests.ActionTests.CharacterResources.MaxSpellPoints
{
    internal class Pathfinder2eTestConfiguration
    {
        public IReadOnlyDictionary<int, int> SpellPointsByLevel { get; private init; }
        public Pathfinder2eTestConfiguration(string className)
        {
            //HACK - Brute Forcing this one since I am very unfamiliar with Pathfinder 2e rules, aiming for proof of concept regarding abstract classes
            //Calculating spellpoints based on spell points to cast per level multiplied by the number of spell slots of that level for that class, added together
            //Pathfinder is different in that each class has a different number of spell slots of each level, rather tahn each "type" of class (full/half/third caster) as in D&D 5e
            this.SpellPointsByLevel = GetSpellPointsByLevel(className);
        }
        private IReadOnlyDictionary<int, int>GetSpellPointsByLevel_BruteForce(string className)
        {
            var spellPointsByLevel = new Dictionary<int, int>();
            switch (className)
            {
                //2 3 5 6 7 9 10 11 13
                case "Sorcerer": //https://pf2.d20pfsrd.com/class/sorcerer/
                    spellPointsByLevel.Add(1, 6); //3 - three first level slots
                    spellPointsByLevel.Add(2, 8); //4 (+2) - four first level slots
                    spellPointsByLevel.Add(3, 17); //4 3 (+9) - four first level slots, three second level slots
                    spellPointsByLevel.Add(4, 20); //4 4 (+3)
                    spellPointsByLevel.Add(5, 35); //4 4 3 (+15)
                    spellPointsByLevel.Add(6, 40); //4 4 4 (+5)
                    spellPointsByLevel.Add(7, 58); //4 4 4 3 (+18)
                    spellPointsByLevel.Add(8, 64); //4 4 4 4
                    spellPointsByLevel.Add(9, 85); //4 4 4 4 3 (+21)
                    spellPointsByLevel.Add(10, 92); //4 4 4 4 4 (+7)
                    spellPointsByLevel.Add(11, 119); //4 4 4 4 4 3 (+27)
                    spellPointsByLevel.Add(12, 128); //4 4 4 4 4 4 (+9)
                    spellPointsByLevel.Add(13, 158); //4 4 4 4 4 4 3 (+30)
                    spellPointsByLevel.Add(14, 168); //4 4 4 4 4 4 4 (+10)
                    spellPointsByLevel.Add(15, 201); //4 4 4 4 4 4 4 3 (+33)
                    spellPointsByLevel.Add(16, 212); //4 4 4 4 4 4 4 4 (+11)
                    spellPointsByLevel.Add(17, 251); //4 4 4 4 4 4 4 4 3 (+39)
                    spellPointsByLevel.Add(18, 264); //4 4 4 4 4 4 4 4 4 (+13)
                    spellPointsByLevel.Add(19, 264); //4 4 4 4 4 4 4 4 4 (+0)
                    spellPointsByLevel.Add(20, 264); //4 4 4 4 4 4 4 4 4 (+0)

                    break;
                case "Wizard":
                case "Cleric":
                case "Witch":
                case "Warlock": //Looking at the rules again, it may just be the Sorcerer that is odd
                case "Bard":
                    spellPointsByLevel.Add(1, 4); //2 - two first level slots
                    spellPointsByLevel.Add(2, 6); //3 (+2) - three first level slots
                    spellPointsByLevel.Add(2, 12); //3 2 (+6) - three first level slots, two second level slots
                    spellPointsByLevel.Add(3, 15); //3 3 (+3)
                    spellPointsByLevel.Add(5, 25); //3 3 2 (+10)
                    spellPointsByLevel.Add(6, 30); //3 3 3 (+5)
                    spellPointsByLevel.Add(7, 42); //3 3 3 2 (+12)
                    spellPointsByLevel.Add(8, 48); //3 3 3 3 (+6)
                    spellPointsByLevel.Add(9, 62); //3 3 3 3 2 (+14)
                    spellPointsByLevel.Add(10, 69); //3 3 3 3 3 (+7)
                    spellPointsByLevel.Add(11, 87); //3 3 3 3 3 2 (+18)
                    spellPointsByLevel.Add(12, 96); //3 3 3 3 3 3 (+9)
                    spellPointsByLevel.Add(12, 116); //3 3 3 3 3 3 2 (+20)
                    spellPointsByLevel.Add(13, 126); //3 3 3 3 3 3 3 (+10)
                    spellPointsByLevel.Add(15, 148); //3 3 3 3 3 3 3 2 (+22)
                    spellPointsByLevel.Add(16, 159); //3 3 3 3 3 3 3 3 (+11)
                    spellPointsByLevel.Add(17, 185); //3 3 3 3 3 3 3 3 2 (+26)
                    spellPointsByLevel.Add(18, 198); //3 3 3 3 3 3 3 3 3 (+13)
                    spellPointsByLevel.Add(19, 198); //3 3 3 3 3 3 3 3 3 (+0)
                    spellPointsByLevel.Add(20, 198); //3 3 3 3 3 3 3 3 3 (+0)
                    break;
            }
            return spellPointsByLevel;
        }
        private IReadOnlyDictionary<int, int>GetSpellPointsByLevel(string className)
        {
            var result = new Dictionary<int, int>();
            var startingSlotCount = 2;
            if (className == "Sorcerer") startingSlotCount = 3;
            int currentSlot = 0;
            int currentSpellPointCost = 1;
            int currentMaxSpellPoints = 0;
            for(int i=1; i <= 18; i++)
            {
                if(i % 2 == 1)
                {
                    currentSlot++;
                    if (currentSlot % 3 == 0) currentSpellPointCost += 2;
                    else currentSpellPointCost++;
                    currentMaxSpellPoints += startingSlotCount * currentSpellPointCost;
                }
                else
                {
                    currentMaxSpellPoints += currentSpellPointCost;
                }
                result.Add(i, currentMaxSpellPoints);
            }
            result.Add(19, currentMaxSpellPoints);
            result.Add(20, currentMaxSpellPoints);
            return result;
        }
    }
}
