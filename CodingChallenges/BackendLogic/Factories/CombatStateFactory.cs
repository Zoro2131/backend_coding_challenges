using RtsCombatState.Models;
namespace RtsCombatState.Factory
{
    public class MakeCombatStates
    {
        public BaseCombatState NeturalState()
        {
            BaseCombatState neturalState = new()
            {
                //Name of State
                Name = "Netural State",

                //Combat check
                //can we attack or not
                CanAttack = true,

                //Precentage modifiers
                MovementSpeedModifier = 1.0,
                AttackRateModifier = 1.0,
                HealthRecoveryRateModifier = 1.0,

                //Flat modifiers
                AttackPowerModifier = 1,
                AttackRangeModifier = 1,
                VisionRangeModifier = 1
            };  
            return neturalState;
        }
    }
}