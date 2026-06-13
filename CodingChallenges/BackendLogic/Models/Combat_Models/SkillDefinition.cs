using RtsCombatExamples.Models;

namespace Skill.Models
{
    public class ActiveSkill
    {
        public required CombatEffect CombatEffect {get; set;}

        //Active:
        //Skill Discription 

        //Skill Rules: 
        //Descripe the ruls that apply to the skill

        //Skill Name
        public string Name {get; set;} = string.Empty;

        //Active Skill Time
        //Sets the Cooldown Time
        public double Cooldown {get; set;}
        public bool IsUnlocked {get; set;}
    }

    public class PassiveSkill
    {
        public required CombatEffect CombatEffect {get; set;}

        //Passive:
        //Skill Discription

        //Skill Rules: 
        //Descripe the ruls that apply to the skill

        //Skill Name
        public string Name {get; set;} = string.Empty;

        //Passive Skill
        public bool IsUnlocked {get; set;}

    }
}