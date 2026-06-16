using RtsCombatState.Models;
using RtsUnitExample.Models;
using Skill.Factory;

namespace RtsCombatExamples.Models
{
    public class MakeUnitDefinition
    {
        public UnitDefinition Recruit()
        {
            MakeActiveSkill makeActiveSkill = new();
            MakePassiveSkill makePassiveSkill = new();

            UnitDefinition recruit = new()
            {
                Name = "Recruit",
                BaseHealth = 50,
                BaseHealthRecoveryRate = 20,
                BaseAttackPower = 10,
                BaseAttackRange = 30,
                BaseVisionRange = 40,
                BaseMovementSpeed = 30,
                PopulationCost = 1,
                BaseUnitExpCost = 100,
                BaseBuildTime = 30,
                ActiveSkill = makeActiveSkill.Grit(),
                PassiveSkill = makePassiveSkill.FieldConditioning()
            };
           return recruit; 
        }
    }
}