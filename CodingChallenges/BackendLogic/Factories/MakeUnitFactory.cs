using RtsCombatState.Factory;
using RtsCombatState.Models;
using RtsUnitExample.Models;

namespace RtsCombatExamples.Models
{
    public class MakeUnitInstance
    {

        //method that creates a unit
        public UnitInstance CreateUnit(
            UnitDefinition unitDefinition,
            BaseCombatState startingState,
            UnitPosition startingPosition
            )
        {


            //unit object
            UnitInstance unit = new()
            {
                //unit properties
                UnitDefinition = unitDefinition,
                CurrentState = startingState,
                MapPosition = startingPosition,
                CurrentHealth = unitDefinition.BaseHealth,
                MaxHealth = unitDefinition.BaseHealth,
                IsAlive = true,
                IsActive = true
            };

            //returning the unit object
            return unit;
        }
       
    }
}