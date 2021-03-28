using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Unit_Sweetling
    {
        public static void BuildSweetlingCharacter()
        {
            CharacterData sweetlingcharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Sweetling",
                Name = "Sweetling",
                NameKey = "Card_XXXI",
                Size = 1,
                Health = 10,
                AttackDamage = 2,
                AssetPath = "sweet/Unit Assets/sweetkin_red.png",
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
                            Description = "Eater gains 1 power and 2 health",
                            DescriptionKey = "Mon_XI",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,

                                    TargetMode = TargetMode.LastFeederCharacter,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamCardUpgradeData = new CardUpgradeDataBuilder
                                    {
                                        BonusDamage = 1,
                                        BonusHP = 2,
                                        HideUpgradeIconOnCard = true,
                                    }.Build(),
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData sweetling = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Sweetling",
                Name = "Sweetling",
                NameKey = "Card_XXXI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXI" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_1.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = sweetlingcharacter
                        }
                    }
            }.BuildAndRegister();
        }
    }
}
