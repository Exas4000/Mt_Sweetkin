using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Sourling
    {
        public static void BuildSourlingCharacter()
        {
            CharacterData sourlingcharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Sourling",
                Name = "Sourling",
                NameKey = "Card_XXVI",
                Size = 1,
                Health = 10,
                AttackDamage = 2,
                AssetPath = "sweet/Unit Assets/sweetkin_green.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 2
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {
                        
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "The front enemy lose 1 power and 2 health",
                            DescriptionKey = "Mon_VI",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,

                                    TargetMode = TargetMode.FrontInRoom,
                                    TargetTeamType = Team.Type.Heroes,
                                    ParamCardUpgradeData = new CardUpgradeDataBuilder
                                    {
                                        BonusDamage = -1,
                                        BonusHP = -2,
                                        HideUpgradeIconOnCard = true,
                                    }.Build(),
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData sourling = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Sourling",
                Name = "Sourling",
                NameKey = "Card_XXVI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXVI" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_2.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = sourlingcharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                    }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXVI",
                UpgradeTitleKey = "Sweetkin_Essence_XXVI",
                SourceSynthesisUnit = sourlingcharacter,
                UpgradeDescription = "Essence_Card_XXVI",
                UpgradeDescriptionKey = "Essence_Card_XXVI",

                
                BonusDamage = 4,
                StatusEffectUpgrades = new List<StatusEffectStackData>
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 2
                     },
                },

            }.Build();
        }
    }
}
