//Futher Backend Study
//Example is a Unit in a RTS game 
//field that need to be track for each unit type

//unit id 
//unit state in combat/retreating/normal
//Unit state as in upgrade level
//if skills are ON/unlocked are they passive or active or both
//pos on map
// have they been giving a pos to relocate to or and activity to do 
// health
// attack power
//population cost
// moving speed
// name
// attack speed, is it based on game ticks or somthing else

//Notes:
// i think it would be best to make a base class type then maybe make inherited class of the type 
//for unit upgrades and there different paths they can take and the will change the 
//parameters/fields based on what we unlock in the game

//Note: Seperate the responablities 
//What it is from what is does 
//what it needs to have for the blueprint form what it needs to have when you make an instance of it 

// Notes:
// Use a Definition + Instance pattern when there is a blueprint
// that can be used to create many objects in the application.
//
// Example:
// UnitDefinition -> UnitInstance
//
// One Recruit definition can create many Recruit units.
//
// Recruit Definition
//      ↓
// Recruit #1
// Recruit #2
// Recruit #3
//
// Position, CombatState, BuffModifiers, and DebuffModifiers
// do not need instances because they are already current-state
// objects that hold information for a specific unit.
/*
All BaseUnits Need:
Name

BaseHealth
BaseRecoveryRate
BaseAttackPower
BaseAttackRange
BaseAttackRate
BaseMovementSpeed

PopulationCost
*/
using Skill.Models;
namespace RtsUnitExample.Models
{
    public class UnitDefinition
    {
        public string Name {get; set;} = string.Empty;
        public int BaseHealth {get; set;} = 0;
        public double BaseHealthRecoveryRate {get; set;} = 0;
        public int BaseAttackPower {get; set;} = 0;
        public int BaseAttackRange {get; set;} = 0;
        public int BaseVisionRange {get; set;} = 0;
        public double BaseAttackRate {get; set;} = 0;
        public double BaseMovementSpeed {get; set;} = 0;
        public int PopulationCost {get; set;} = 0;
        public int BaseUnitExpCost {get; set;} = 0;
        public int BaseBuildTime {get; set;} = 0;
        public required ActiveSkill ActiveSkill {get; set;}
        public required PassiveSkill PassiveSkill {get; set;}
    }
}

