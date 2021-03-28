using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class teamaid
    {
        public static void BuildMaidCharacter()
        {
            CharacterData maidchar = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Unit_Maid",
                Name = "Tea Maid",
                NameKey = "Card_XXIX",
                Size = 2,
                Health = 22,
                AttackDamage = 4,
                AssetPath = "sweet/Unit Assets/sweetkin_large_tea.png", //change later
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = true,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 3
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnEaten,
                        Description = "Cure all negative effects from the eater",
                        DescriptionKey = "Mon_IX",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveAllStatusEffects,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                ShouldTest = true,
                                ParamStatusEffects = new StatusEffectStackData[]{}
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = "ephemeral",
                                        count = 999
                                    }
                                    
                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Sap,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Dazed,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Emberdrain,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Fragile,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Frostbite,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.HealImmunity,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Inert,
                                        count = 999
                                    }

                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectRemoveStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                HideTooltip = true,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Rooted,
                                        count = 999
                                    }

                                }
                            }
                        }
                    }
                }

            }.BuildAndRegister();

            CardData maid =  new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Maid",
                Name = "Tea Maid",
                NameKey = "Card_XXIX",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXIX" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_9.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = maidchar
                        }
                }

            }.BuildAndRegister();
        }
    }
}
