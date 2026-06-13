using RtsStatModifierExample.Models;

namespace RtsCombatExamples.Models
{
    public class CombatEffect
    {
        public string Name {get; set;} = string.Empty;
        public double Duration {get; set;}
        public bool IsActive {get; set;}
        public StatModifier StatModifier {get; set;} = new StatModifier();
    }
}
