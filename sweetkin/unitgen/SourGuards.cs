using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class SourGuards
    {
        public static void BuildSourGuardsCharacter()
        {
            CharacterData sourguardcharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_SourGuard",
                Name = "Sour Guard",
                NameKey = "Card_XXIV",
                Size = 2,
                Health = 16,
                AttackDamage = 4,
                AssetPath = "sweet/Unit Assets/sweetkin_tall_green.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = true,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 4
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {
                        
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "the front enemy lose 1 power and 4 health",
                            DescriptionKey = "Mon_IV",
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
                                        BonusHP = -4,
                                        HideUpgradeIconOnCard = true,
                                    }.Build(),
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData sourguard = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_SourGuard",
                Name = "Sour Guard",
                NameKey = "Card_XXIV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXIV" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_4.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = sourguardcharacter
                        }
                    }
            }.BuildAndRegister();

            CharacterData sourbosscharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Lime",
                Name = "Lime",
                NameKey = "Card_XXV",
                Size = 3,
                Health = 30,
                AttackDamage = 15,
                AssetPath = "sweet/Unit Assets/sweetkin_large_lime.png",
                //SubtypeKeys = new List<string> { "SubtypesData_Snack" }, enable if it matters
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {                        
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnAnyMonsterDeathOnFloor,
                            Description = "Summon a Sour Guard then send the front unit to the back",
                            DescriptionKey = "Mon_V",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                                    TargetMode = TargetMode.BackInRoom,
                                    ParamCharacterData = sourguardcharacter,
                                    ParamInt = 1
                                },
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectFloorRearrange,
                                    TargetMode = TargetMode.FrontInRoom,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamInt = 1
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData sweetling = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Lime",
                Name = "Lime",
                NameKey = "Card_XXV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXV" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_10.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = sourbosscharacter
                        }
                    }
            }.BuildAndRegister();
        }
    }
}
