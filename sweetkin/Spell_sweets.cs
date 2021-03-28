using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin
{
    class Spell_sweets
    {
        public static void BuildSpellHospitality()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Hospi",
                Name = "Hospitality",
                Description = "Enhance the target with 3 health and gain [effect1.status0.power] Sap",
                NameKey = "Card_XIX",
                OverrideDescriptionKey = "Spell_XIX",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XIX" },
                Cost = 1,
                Rarity = CollectableRarity.Starter,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_XIX.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                   
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,
                        
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,
                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                        {
                            BonusHP = 3,
                            HideUpgradeIconOnCard = true,
                        }.Build(),
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,

                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Sap,
                                count = 1
                            }
                        }
                    }
                }

            }.BuildAndRegister();
        }


        public static void Buildtestforbanner()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_test",
                Name = "Hospitality",
                Description = "Enhance the target with 3 health and gain [effect1.status0.power] Sap",
                Cost = 1,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/wantedResolution.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool  },
                EffectBuilders = new List<CardEffectDataBuilder>
                {

                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,

                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,
                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                        {
                            BonusHP = 3,
                            HideUpgradeIconOnCard = true,
                        }.Build(),
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,

                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Sap,
                                count =1
                            }
                        }
                    }
                }

            }.BuildAndRegister();
        }
    }
}
