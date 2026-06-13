using RtsCombatExamples.Models;
using RtsStatModifierExample.Models;

namespace Debuff.Factory
{
    public class MakeDebuffs
    {
        public CombatEffect Suppressed()
        {
            CombatEffect suppressed = new()
            {
                //Effect: Incoming fire forces the unit to keep its head down.
                //suppressed: MovementSpeedModifier = -0.25 AttackRateModifier = -0.15

                //Effect Rule: 
                //Rule: 
                //Is learned from a building research maybe

                //Effect Name
                Name = "Suppressed",

                //When makeing the Debuffs how are they delivered to the Units 
                //example: form buildings through training or from other units or something else
                //this will determine if the effect is permerenet or does it have a duration

                //no duration
                Duration = 5,

                IsActive = true,

                //StatModifier will set the stats affected by this skill
                StatModifier = new StatModifier
                {
                    //Percentage modifiers 
                    MovementSpeedModifier = -0.25,
                    AttackRateModifier = -0.15,
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
            return suppressed;
        }
            
    }
}