namespace RtsCombatState.Models
{
    //The combat state will be selected based on the zone the unit is currently in. 
    public class BaseCombatState
    {
        public string Name {get; set;} = string.Empty;
        public bool CanAttack {get; set;}

        //Percentage modifiers
        public double MovementSpeedModifier {get; set;}
        public double AttackRateModifier {get; set;}
        public double HealthRecoveryRateModifier {get; set;} = 0;

        //Flat modifiers
        public int AttackPowerModifier {get; set;} = 0;
        public int AttackRangeModifier {get; set;} = 0;
        public int VisionRangeModifier {get; set;} = 0;
    }
}
