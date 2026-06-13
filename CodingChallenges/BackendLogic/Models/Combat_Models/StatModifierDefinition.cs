namespace RtsStatModifierExample.Models 
{
    public class StatModifier
    {
        //Percentage modifiers 
        public double MovementSpeedModifier {get; set;} 
        public double AttackRateModifier {get; set;} 
        public double HealthRecoveryRateModifier {get; set;} 
        public double ActiveSkillReadytimeModifier {get; set;} 

        //Flat modifiers 
        public int TotalHealthModifier {get; set;} 
        public int AttackPowerModifier {get; set;} 
        public int AttackRangeModifier {get; set;} 
        public int VisionRangeModifier {get; set;} 
        public int UnitExpCostModifier {get; set;} 
        public int BuildTimeModifier {get; set;} 
    }
}