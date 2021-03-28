using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.upgrades
{
    class Janitor_III
    {
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder upgrade = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = "Janitor_III",
                UpgradeDescriptionKey = "3full",
                UseUpgradeHighlightTextTags = true,
                BonusHP = 30,
                BonusDamage = 0,


                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                        DescriptionKey = "1f",
                        HideTriggerTooltip = false,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Monsters,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                new StatusEffectStackData
                                    {
                                    statusId = VanillaStatusEffectIDs.Regen,
                                    count = 5
                                    },

                                }
                            }
                        }
                    },
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnAnyMonsterDeathOnFloor,
                        DescriptionKey = "2f",
                        HideTriggerTooltip = false,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Monsters,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                new StatusEffectStackData
                                    {
                                    statusId = "eatmany",
                                    count = 3
                                    },

                                }
                            }
                        }
                    },
                    new CharacterTriggerDataBuilder
                    {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Deal 30 damage twice",
                            DescriptionKey = "3f",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Heroes,
                                    ParamInt = 50

                                },
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Heroes,
                                    ParamInt = 50

                                }
                            }

                    }
                }
            };
            return upgrade;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
