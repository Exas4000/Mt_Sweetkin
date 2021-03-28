using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Enums.MTTriggers;
using Trainworks.Managers;
using HarmonyLib;

namespace sweetkin.Triggers
{
    class Forcefeed
    {
        public static class OnForcefeed
        {
            //goal: unit gets eaten by the heroes rather than the monsters

            public static CharacterTrigger OnForcefeedTrigger = new CharacterTrigger("OnForcefeed");
            public static CardTrigger OnForcefeedCardTrigger = new CardTrigger("OnForcefeed");

            static OnForcefeed()
            {
                CustomTriggerManager.AssociateTriggers(OnForcefeedCardTrigger, OnForcefeedTrigger);
            }


            //attempt at detecting the trigger, synthax is wrong
            /*
            [HarmonyPatch(typeof(CombatFeederRules), "GetIsFoodUnit")]
            class GetRealFoodUnit
            {
                static void Prefix(CharacterState charState)
                {
                    if (charState.HasStatusEffect("inedible"))
                    {
                        return false;
                    }
                    foreach (CharacterTriggerState trigger in charState.GetTriggers())
                    {
                        if (trigger.GetTrigger() == CharacterTriggerData.Trigger.OnEaten )
                        {
                            return true;
                        }
                        if (trigger.GetTrigger() == CharacterTriggerData.Trigger.OnForcefeedTrigger)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }*/

            // attempt #2, realise that i can't find the required spot to remove buffet out of a char.
            /*[HarmonyPatch(typeof(CombatManager), "DoFeederRules")]
            class Sweetfeed
            {
                static void Postfix(CharacterState charState)
                {
                    if ( charState.HasStatusEffect("eatmany"))
                    {
                        charState.RemoveStatusEffect,
                    }
                }
            }*/

            ///might be better to just keep the mod as is.
            /// i was told to use CustomTriggerManager.QueueAndRunTrigger           
            //List<CharacterState> units = new List<CharacterState>();
            //monsterManager.AddCharactersInRoomToList(units);
            // in order to activate the trigger. the issue here, is that i am still missing 
            //either the whole behavior for eating (removing buffet and dying) or it just is the same as eaten


        }


    }
}
