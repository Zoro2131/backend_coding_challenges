//The Unit Instance should contain all things that the unit needs to let the game know at the current momemt in the game state

namespace RtsUnitExample.Models
{
    public class UnitInstance
    {
        public int Id {get; set;}
        
        public UnitDefinition UnitDefinition {get; set;}
        public int CurrentHealth {get; set;}
        public int MaxHealth {get; set;} 
        //CombatState will be its own Class object that will need to be passed in 

        //There will be some negitives buffs that come from the combat states 1
        public CombatState CurrentState {get; set;} 
        //Will need to make a Class object that takes in the map x/y/zoneID for zone type to determine combat state
        // and maybe later add z and rotation fields
        public Position MapPosition {get; set;} 
        //Buffs and Debuffs aer also a object that will need to be passed in 
        //README: the buffs should only come form your own units / permenet building upgrades 
        public BuffModifiers ActiveBuffs {get; set;}

        //This should only come form enemy combatants skills or passives 
        public DebuffModifiers ActiveDebuffs {get; set;}
        public bool IsAlive {get; set;}
        public bool IsActive {get; set;} 
        public double ActiveSkillReadytime {get; set;}
    }
}