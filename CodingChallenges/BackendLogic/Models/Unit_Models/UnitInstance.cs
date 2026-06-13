//The Unit Instance should contain all things that the unit needs to let the game know at the current momemt in the game state

using RtsCombatExamples.Models;
using RtsCombatState.Models;

namespace RtsUnitExample.Models
{
    public class UnitInstance
    {
        public int Id {get; set;}
        
        public required UnitDefinition UnitDefinition {get; set;}
        public int CurrentHealth {get; set;}
        public int MaxHealth {get; set;} 
        //CombatState will be its own Class object that will need to be passed in 

        //There will be some negitives buffs that come from the combat states 1
        public required BaseCombatState CurrentState {get; set;}
        //Will need to make a Class object that takes in the map x/y/zoneID for zone type to determine combat state
        // and maybe later add z and rotation fields
        public required UnitPosition MapPosition {get; set;} 
        //Buffs and Debuffs aer also a object that will need to be passed in 
        //README: the buffs should only come form your own units / permenet building upgrades 

        //Used for buffs form there bases or from skills form friendly units
        public List<CombatEffect> ActiveBuffs {get; set;} = new();

        //This should only come from enemy combatants skills or passives 
        //Used for debuffs from enemy units
        public List<CombatEffect> ActiveDebuffs {get; set;} = new();
        public bool IsAlive {get; set;}
        public bool IsActive {get; set;} 
        public double ActiveSkillReadyTime {get; set;}
    }
}