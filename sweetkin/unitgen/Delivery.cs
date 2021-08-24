using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Delivery
    {
        public static void BuildDeliveryCharacter()
        {
            CharacterData Delicharacter = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Unit_Delivery",
                Name = "Delivery Boy",
                NameKey = "Card_XXI",
                Size = 1,
                Health = 1,
                AttackDamage = 1,
                AssetPath = "sweet/Unit Assets/sweetkin_orange.png",
                PriorityDraw = false,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = VanillaStatusEffectIDs.Quick,
                        count = 1
                     }
                }
                //TriggerBuilders = new List<CharacterTriggerDataBuilder>               
                //{
                 //   new CharacterTriggerDataBuilder
                   // {
                     //   Trigger = CharacterTriggerData.Trigger.OnSpawn,
                     //   Description = "Quick",
                       // EffectBuilders = new List<CardEffectDataBuilder>
                       // {
                         //       new CardEffectDataBuilder
                           //     {
                             //       EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                               //     TargetMode = TargetMode.Self,
                                 //   TargetTeamType = Team.Type.Monsters,
                                   // ParamStatusEffects = new StatusEffectStackData[]
                                   // {
                                     //   new StatusEffectStackData
                                       // {
                                         //   statusId = VanillaStatusEffectIDs.Quick,
                                           // count = 1
                                  //      }
                                 //   }
                             //   }
                     //   },
                   // }
                //}
            }.BuildAndRegister();
            

            CardData Deli = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Delivery",
                Name = "Delivery Boy",
                NameKey = "Card_XXI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXI" },
                Cost = 0,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_3.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Delicharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXI",
                UpgradeTitleKey = "Sweetkin_Essence_XXI",
                SourceSynthesisUnit = Delicharacter,
                UpgradeDescription = "Essence_Card_XXI",
                UpgradeDescriptionKey = "Essence_Card_XXI",

                CostReduction = 1,

            }.Build();
        }
    }
}
