using RtsCombatExamples.Models;
using RtsStatModifierExample.Models;

namespace Buff.Factory
{
    public class MakeBuffs
    {
        public CombatEffect AdrenalineRush()
        {
            CombatEffect adrenalineRush = new()
            {
                //Effect:
                //AdrenalineRush: +Movement Speed, +Attack Rate

                //Effect Rule: 
                //Rule: 
                //Is learned from a building research maybe

                //Effect Name
                Name = "Adrenaline Rush",

                //When makeing the Buffs how are they delivered to the Units 
                //example: form buildings through training or from other units or something else
                //this will determine if the effect is permerenet or does it have a duration

                //no duration
                Duration = 0,

                IsActive = true,

                //StatModifier will set the stats affected by this skill
                StatModifier = new StatModifier
                {
                    //Percentage modifiers 
                    MovementSpeedModifier = .25,
                    AttackRateModifier = .10,
                    //HealthRecoveryRateModifier
                    //ActiveSkillReadytimeModifier

                    //Flat modifiers 
                    //TotalHealthModifier = 10,
                    //AttackPowerModifier = 2,
                    //Will be one tile futher
                    //AttackRangeModifier = 1,
                    //VisionRangeModifier = 1,
                    //UnitExpCostModifier
                    //BuildTimeModifier 
                }

            };  
            return adrenalineRush;
        }
            
    }
}