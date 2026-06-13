using RtsCombatExamples.Models;
using RtsStatModifierExample.Models;
using Skill.Models;

namespace Skill.Factory
{
    public class MakePassiveSkill
    {
        //For Recruit Passive Skill
        public PassiveSkill FieldConditioning()
        {
            CombatEffect combatDiscipline = new()
            {
                //Active:
				//Grit: Temporary small Attackand Defense bonus while stationary

                //Grit Rule: 
                //If a player issues a movement command the skill will cancel and start the cooldown timer

                //Effect Name
                Name = "Combat Discipline",

                //Active Skill Time
                //Sets the how long the skill is active
                Duration = 0,

                //Passive Skill
                //IsActive Rule Set:
                //If the skill is unlocked it will not have a duration and will just be unlocked or true
                //If the skill is Passive IsActive can be set to true unless countered by another ability
                //If the skill is active IsActive can be set to true unless countered by another ability

                IsActive = true,

                //StatModifier will set the stats affected by this skill
                StatModifier = new StatModifier
                {
                    //Percentage modifiers 
                    MovementSpeedModifier = 0.05,
                    //AttackRateModifier
                    HealthRecoveryRateModifier = 0.05,
                    ActiveSkillReadytimeModifier = 0.05,

                    //Flat modifiers 
                    TotalHealthModifier = 10,
                    //AttackPowerModifier = 2,
                    //Will be one tile futher
                    //AttackRangeModifier = 1,
                    //VisionRangeModifier = 1,
                    //UnitExpCostModifier
                    //BuildTimeModifier 
                }
            };

            PassiveSkill FieldConditioning = new PassiveSkill
            {
                Name = "Field Conditioning",
                IsUnlocked = true,

                CombatEffect = combatDiscipline
            };


            return FieldConditioning;
        }
    }
}
